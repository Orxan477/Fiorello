using Microsoft.Extensions.DependencyInjection;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace FiorellaAllProcesses.Utilities
{
    public static class Helper
    {
        public static void RemoveFile(string root, string folder, string image)
        {
            string path = Path.Combine(root, folder, image);
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }


    }

    public enum UserRoles
    {
        Admin,
        Member,
        Moderator
    }
    public static class Email
    {
        public static void SendEmailAsync(string email, string body, string subject)
        {
            using (var client = new SmtpClient("smtp.googlemail.com", 587))
            {
                client.Credentials =
                            new NetworkCredential("orxanqanbarov73@gmail.com", "200267926orxan");
                client.EnableSsl = true;
                var message = new MailMessage("orxanqanbarov73@gmail.com", email);
                message.Body = body;
                message.Subject = subject;
                message.IsBodyHtml = true;
                client.Send(message);
            }
        }
    }
}
