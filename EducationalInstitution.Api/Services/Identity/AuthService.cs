using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Models.Identity;
using EducationalInstitution.Api.Models.Input;
using EducationalInstitution.Api.Responses;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;

namespace EducationalInstitution.Api.Services.Identity
{
    public class AuthService : IAuthService
    {
        private readonly IAuthService _authService;
        private readonly IEmailService _emailService;

        public AuthService(IAuthService service, IEmailService emailService)
        {
            _authService = service;
            _emailService = emailService;
        }

        public SingleResponse<User> GetById(int id)
        {
            var result = GetById(id);

            if (result == null) return ResponseStatus.NotFound;

            return result;
        }

        public SingleResponse<User> Register(UserInput input)
        {
            input.Password = HashPassword(input.Password);

            return _authService.Register(input);
        }

        private static string HashPassword(string password, HashAlgorithm? algorithm = null)
        {
            //if (algorithm == null)
            //{
            //    algorithm = SHA256.Create();
            //}

            algorithm ??= SHA256.Create();

            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashBytes = algorithm.ComputeHash(passwordBytes);

            return Convert.ToBase64String(hashBytes);
        }

        public SingleResponse<bool> Delete(int id)
        {
            var result = _authService.GetById(id);

            if (result == null) return ResponseStatus.NotFound;

            return _authService.Delete(id);
        }

        public SingleResponse<bool> ChangePassword(int userId, string currentPassword, string newPassword)
        {
            return _authService.ChangePassword(userId, currentPassword, newPassword);
        }

        public SingleResponse<bool> AddPassword(int userId, string password)
        {
            return _authService.AddPassword(userId, password);
        }

        public SingleResponse<bool> ConfirmEmail(int userId)
        {
            var user = _authService.FindUserByEmail(u => u.Id == userId);

            if (user == null) return ResponseStatus.NotFound;

            //Random verification code generation
            var confirmationCode = Guid.NewGuid().ToString();

            var emailSentRespon = _emailService.SendConfirmationEmail(user.Email, confirmationCode);

            if (emailSentRespon == null) return ResponseStatus.Failed;

            var isEmailConfirmed = ConfirmEmail(userId);

            if (isEmailConfirmed == null) return ResponseStatus.Failed;

            return ResponseStatus.Success;
        }

        public SingleResponse<bool> ConfirmPassword(int userId, string confirmationCode)
        {
            return ResponseStatus.Success;
        }

        public SingleResponse<bool> AddRoleToUser(int userId, Role role)
        {
            return _authService.AddRoleToUser(userId, role);
        }

        public SingleResponse<bool> RemoveRoleFromUser(int userId, string role)
        {
            return _authService.RemoveRoleFromUser(userId, role);
        }

       public User FindUserByEmail(Expression<Func<User, bool>> predicate)
       {
            return _authService.FindUserByEmail(predicate);
       }

        public SingleResponse<User> Login(string email, string password)
        {

            var user = _authService.FindUserByEmail(u => u.Email == email);

            if (user == null)
                return ResponseStatus.NotFound;

            if (!VerifyPassword(password, user.Password))
                return ResponseStatus.Unauthorized;

            return ResponseStatus.Success;
        }

        private static bool VerifyPassword(string password, string passwordHash)
        {
            using SHA256 sha256 = SHA256.Create();

            // Hash the provided password and compare it with the stored hash
            string hashedPassword = HashPassword(password, sha256);

            return string.Equals(hashedPassword, passwordHash);
        }

        public SingleResponse<bool> Logout(int userId)
        {
            return ResponseStatus.Success;
        }
    }
}