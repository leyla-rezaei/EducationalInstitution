using AutoMapper;
using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Models.Input;
using EducationalInstitution.Api.Responses;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Linq.Expressions;
using System.Security.Cryptography;

namespace EducationalInstitution.Api.Services.Identity
{
    public class AuthService : IAuthService
    {
        private readonly IAuthService _service;
        private readonly IEmailService _emailService;
        private readonly IMapper _mapper;

        public AuthService(IAuthService service, IEmailService emailService, IMapper mapper)
        { 
            _service = service;
            _emailService = emailService;
            _mapper = mapper;
        }

        public SingleResponse<User> CreateUser(UserInput input, CancellationToken cancellationToken)
        {
            input.Password = HashPassword(input.Password);

            return _service.CreateUser(input, cancellationToken);
        }

        public SingleResponse<bool> DeleteUser(int userId, CancellationToken cancellationToken)
        {
            return _service.DeleteUser(userId, cancellationToken);
        }

        public SingleResponse<bool> ChangePassword(int userId, string currentPassword, string newPassword)
        {
            return _service.ChangePassword(userId, currentPassword, newPassword);
        }

        public SingleResponse<bool> AddPassword(int userId, string password)
        {
            return _service.AddPassword(userId, password);
        }

        public SingleResponse<bool> ConfirmEmail(int userId)
        {
            var user = _service.FindUserByEmail(u => u.Id == userId);

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

        public SingleResponse<bool> AddRoleToUser(int userId, string role)
        {
            return _service.AddRoleToUser(userId, role);
        }

        public SingleResponse<bool> RemoveRoleFromUser(int userId, string role)
        {
            return _service.RemoveRoleFromUser(userId, role);
        }

        public User FindUserByEmail(Expression<Func<User, bool>> predicate)
        {
            return _service.FindUserByEmail(predicate);
        }
        public SingleResponse<User> Login(string email, string password, CancellationToken cancellationToken)
        {

            var user = _service.FindUserByEmail(u => u.Email == email);

            if (user == null)
                return ResponseStatus.NotFound;

            if (!VerifyPassword(password, user.Password))
                return ResponseStatus.Unauthorized;

            return ResponseStatus.Success;
        }

        public SingleResponse<bool> Logout(int userId)
        {
            return ResponseStatus.Success;
        }

        private static string HashPassword(string password, byte[]? salt = null, bool needsOnlyHash = false)
        {
            if (salt == null || salt.Length != 16)
            {
                // generate a 128-bit salt using a secure PRNG
                salt = new byte[128 / 8];
                using var rng = RandomNumberGenerator.Create();
                rng.GetBytes(salt);
            }

            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                 password: password,
               salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 10000,
               numBytesRequested: 256 / 8));

            if (needsOnlyHash) return hashed;
            // password will be concatenated with salt using ':'
            return $"{hashed}:{Convert.ToBase64String(salt)}";
        }

        private static bool VerifyPassword(string hashedPasswordWithSalt, string passwordToCheck)
        {
            // retrieve both salt and password from 'hashedPasswordWithSalt'
            var passwordAndHash = hashedPasswordWithSalt.Split(':');
            if (passwordAndHash == null || passwordAndHash.Length != 2)
                return false;
            var salt = Convert.FromBase64String(passwordAndHash[1]);
            if (salt == null)
                return false;
            // hash the given password
            var hashOfpasswordToCheck = HashPassword(passwordToCheck, salt, true);
            // compare both hashes
            if (String.Compare(passwordAndHash[0], hashOfpasswordToCheck) == 0)
            {
                return true;
            }
            return false;
        }
    }
}