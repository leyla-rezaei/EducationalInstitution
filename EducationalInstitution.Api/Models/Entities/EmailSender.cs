using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net;
using System.Net.Mail;

namespace EducationalInstitution.Api.Models.Entities
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
           
            var smtpClient = new SmtpClient("your-smtp-server.com", 587)
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("your-username", "your-password"),
                EnableSsl = true
            };

            var mailMessage = new MailMessage("your-email@domain.com", email, subject, message)
            {
                IsBodyHtml = true
            };

            return smtpClient.SendMailAsync(mailMessage);
        }
    }
}