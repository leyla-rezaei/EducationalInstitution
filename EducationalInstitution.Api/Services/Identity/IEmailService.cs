using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Responses;

namespace EducationalInstitution.Api.Services.Identity
{
    public interface IEmailService
    {
        SingleResponse<User> SendPasswordResetEmail(string email, string resetCode);
        SingleResponse<User> SendWelcomeEmail(string email);
        SingleResponse<User> SendNotificationEmail(string email, string subject, string message);
        SingleResponse<User> SendConfirmationEmail(string email, string confirmationCode);
        SingleResponse<User> SendAccountActivationEmail(string email, string activationCode);
    }
}