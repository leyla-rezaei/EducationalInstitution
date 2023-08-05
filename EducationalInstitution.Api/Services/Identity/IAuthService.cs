using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Models.Identity;
using EducationalInstitution.Api.Models.Input;
using EducationalInstitution.Api.Responses;
using System.Linq.Expressions;

namespace EducationalInstitution.Api.Services.Identity
{
    public interface IAuthService
    {
        SingleResponse<User> GetById(int id);
        SingleResponse<User> Register(UserInput input);
        SingleResponse<bool> Delete(int id);
        SingleResponse<bool> ChangePassword(int userId, string currentPassword, string newPassword);
        SingleResponse<bool> AddPassword(int userId, string password);
        SingleResponse<bool> ConfirmEmail(int userId);
        SingleResponse<bool> ConfirmPassword(int userId, string confirmationCode);
        SingleResponse<bool> AddRoleToUser(int userId, Role role);
        SingleResponse<bool> RemoveRoleFromUser(int userId, string role);
        SingleResponse<User> Login(string email, string password);
        SingleResponse<bool> Logout(int userId);
       User FindUserByEmail(Expression<Func<User, bool>> predicate);
    }
}