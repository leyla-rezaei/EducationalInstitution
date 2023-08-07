using Microsoft.AspNetCore.Mvc;
using EducationalInstitution.Api.Services.Identity;
using EducationalInstitution.Api.Responses;
using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Models.Input;
using EducationalInstitution.Api.Models.Identity;
using Microsoft.AspNetCore.Authorization;

namespace EducationalInstitution.Api.Controllers.Identity
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        [Route("register")]
        [Authorize]
        public SingleResponse<User> Register(UserInput input)
        {
            return _authService.Register(input);
        }

        [HttpDelete]
        [Route("users/{userId}")]
        [Authorize]
        public SingleResponse<bool> Delete(int userId)
        {
            return _authService.Delete(userId);
        }

        [HttpPut]
        [Route("users/{userId}/password/change")]
        [Authorize]
        public SingleResponse<bool> ChangePassword(int userId, string currentPassword, string newPassword)
        {
            return _authService.ChangePassword(userId, currentPassword, newPassword);
        }

        [HttpPut]
        [Route("users/{userId}/password")]
        [Authorize]
        public SingleResponse<bool> AddPassword(int userId, string password)
        {
            return _authService.AddPassword(userId, password);
        }

        [HttpPut]
        [Route("users/{userId}/email/confirm")]
        [Authorize]
        public SingleResponse<bool> ConfirmEmail(int userId)
        {
            return _authService.ConfirmEmail(userId);
        }

        [HttpPut]
        [Route("users/{userId}/password/confirm")]
        [Authorize]
        public SingleResponse<bool> ConfirmPassword(int userId, string confirmationCode)
        {
            return _authService.ConfirmPassword(userId, confirmationCode);
        }

        [HttpPost]
        [Route("users/{userId}/roles")]
        [Authorize]
        public SingleResponse<bool> AddRoleToUser(int userId, Role role)
        {
            return _authService.AddRoleToUser(userId, role);
        }

        [HttpDelete]
        [Route("users/{userId}/roles")]
        [Authorize]
        public SingleResponse<bool> RemoveRoleFromUser(int userId, string role)
        {
            return _authService.RemoveRoleFromUser(userId, role);
        }

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public SingleResponse<bool> Login(string email, string password)
        {
            return _authService.Login(email, password);
        }

        [HttpPost]
        [Route("Logout")]
        [Authorize]
        public SingleResponse<bool> Logout(int userId)
        {
            return _authService.Logout(userId);
        }
    }
}