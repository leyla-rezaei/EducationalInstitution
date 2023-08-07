using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Models.Identity;
using EducationalInstitution.Api.Models.Input;
using EducationalInstitution.Api.Repository.Contracts;
using EducationalInstitution.Api.Responses;
using Microsoft.AspNetCore.Identity;
using System.Security.Cryptography;

namespace EducationalInstitution.Api.Services.Identity
{
    public class AuthService : IAuthService
    {
        private readonly IAuthService _authService;
        private readonly IEmailService _emailService;
        private readonly IBaseRepository<User> _repository;
        private readonly IPasswordHasher<User> _passwordHasher;
        private readonly HashAlgorithm _hashAlgorithm;

        public AuthService(IAuthService _service, IEmailService emailService
            , IBaseRepository<User> repository, IPasswordHasher<User> passwordHasher)
        {
            _authService = _service;
            _emailService = emailService;
            _repository = repository;
            _passwordHasher = passwordHasher;
            _hashAlgorithm = SHA256.Create();
        }

        public SingleResponse<User> GetById(int id)
        {
            var userResponse = GetById(id);

            if (userResponse.Result == null) return ResponseStatus.NotFound;

            return userResponse;
        }

        public SingleResponse<User> Register(UserInput input)
        {
            var user = new User();
            user.Password = _passwordHasher.HashPassword(user, input.Password);

            return _authService.Register(input);
        }

        public SingleResponse<bool> Delete(int id)
        {
            var userResponse = _authService.GetById(id);

            if (userResponse.Result == null)
                return ResponseStatus.NotFound;

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
            var userResponse = GetById(userId);

            if (userResponse.Result == null) return ResponseStatus.NotFound;

            // Random verification code generation
            var confirmationCode = Guid.NewGuid().ToString();

            var emailSentResponse = _emailService
                .SendConfirmationEmail(userResponse.Result.Email, confirmationCode);

            if (emailSentResponse.Result == null) return ResponseStatus.Failed;

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

        public SingleResponse<bool> Login(string email, string password)
        {
            var user = _repository.GetAll().FirstOrDefault(x => x.Email == email);

            if (user == null) return ResponseStatus.NotFound;

            var result = _passwordHasher.VerifyHashedPassword(user, user.Password, password);

            if (result == PasswordVerificationResult.Failed)
                return ResponseStatus.Unauthorized;

            return ResponseStatus.Success;
        }

        public SingleResponse<bool> Logout(int userId)
        {
            return ResponseStatus.Success;
        }
    }
}