using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net.Mail;
using System.Threading.Tasks;

namespace E_commerce_website.Confirmation
{
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var fromMail = "ecommercea97@gmail.com";
            var frompassword = "App123456789";
            var message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = subject;
            message.To.Add(email);
            message.Body = $"<html><body>{htmlMessage}</body></html>";
            message.IsBodyHtml = true;


            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential(fromMail, frompassword);
            smtp.EnableSsl = true;
            smtp.Send(message);

        }

        
    }
}
