using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Responses;
using System.Net;
using System.Net.Mail;

namespace EducationalInstitution.Api.Services.Identity
{
    public class EmailService : IEmailService
    {
        private readonly SmtpClient smtpClient;
        private readonly string senderEmailAddress;

        public EmailService(string smtpHost, int smtpPort, string smtpUsername, string smtpPassword, string senderEmailAddress)
        {
            smtpClient = new SmtpClient(smtpHost, smtpPort)
            {
                Credentials = new NetworkCredential(smtpUsername, smtpPassword),
                EnableSsl = true
            };

            this.senderEmailAddress = senderEmailAddress;
        }

        public SingleResponse<User> SendAccountActivationEmail(string email, string activationCode)
        {
            try
            {
                MailMessage mailMessage = new MailMessage(senderEmailAddress, email);
                mailMessage.Subject = "Account Activation";
                mailMessage.Body = $"Dear User,\n\nYour account activation code is: {activationCode}\n\nRegards,\nThe Educational Institution Team";

                smtpClient.Send(mailMessage);

                return new SingleResponse<User> { Message = "Account activation email sent successfully." };
            }
            catch (Exception ex)
            {
                return new SingleResponse<User> { Message = $"Failed to send account activation email: {ex.Message}" };
            }
        }

        public SingleResponse<User> SendConfirmationEmail(string email, string confirmationCode)
        {
            try
            {
                MailMessage mailMessage = new MailMessage(senderEmailAddress, email);
                mailMessage.Subject = "Email Confirmation";
                mailMessage.Body = $"Dear User,\n\nPlease confirm your email using this code: {confirmationCode}\n\nRegards,\nThe Educational Institution Team";

                smtpClient.Send(mailMessage);

                return new SingleResponse<User> { Message = "Confirmation email sent successfully." };
            }
            catch (Exception ex)
            {
                return new SingleResponse<User> { Message = $"Failed to send confirmation email: {ex.Message}" };
            }
        }

        public SingleResponse<User> SendNotificationEmail(string email, string subject, string message)
        {
            try
            {
                MailMessage mailMessage = new MailMessage(senderEmailAddress, email);
                mailMessage.Subject = subject;
                mailMessage.Body = message;

                smtpClient.Send(mailMessage);

                return new SingleResponse<User> { Message = "Notification email sent successfully." };
            }
            catch (Exception ex)
            {
                return new SingleResponse<User> { Message = $"Failed to send notification email: {ex.Message}" };
            }
        }

        public SingleResponse<User> SendPasswordResetEmail(string email, string resetCode)
        {
            try
            {
                MailMessage mailMessage = new MailMessage(senderEmailAddress, email);
                mailMessage.Subject = "Password Reset";
                mailMessage.Body = $"Dear User,\n\nTo reset your password, please use this code: {resetCode}\n\nRegards,\nThe Educational Institution Team";

                smtpClient.Send(mailMessage);

                return new SingleResponse<User> { Message = "Password reset email sent successfully." };
            }
            catch (Exception ex)
            {
                return new SingleResponse<User> { Message = $"Failed to send password reset email: {ex.Message}" };
            }
        }

        public SingleResponse<User> SendWelcomeEmail(string email)
        {
            try
            {
                MailMessage mailMessage = new MailMessage(senderEmailAddress, email);
                mailMessage.Subject = "Welcome to Educational Institution";
                mailMessage.Body = $"Dear User,\n\nWelcome to Educational Institution! We are excited to have you on board.\n\nRegards,\nThe Educational Institution Team";

                smtpClient.Send(mailMessage);

                return new SingleResponse<User> { Message = "Welcome email sent successfully." };
            }
            catch (Exception ex)
            {
                return new SingleResponse<User> { Message = $"Failed to send welcome email: {ex.Message}" };
            }
        }
    }
}