using MailKit.Net.Smtp;
using MimeKit;
using Newtonsoft.Json;

namespace AndreysPortfolio.EmailService
{
    public class EmailSender
    {
        public void SendEmailAsync(string email, string subject, string message)
        {
            using var emailMessage = new MimeMessage();

            string json = File.ReadAllText("wwwroot/AuthorizationData.json");
            var authorization = JsonConvert.DeserializeObject<AuthorizationData>(json);

            emailMessage.From.Add(new MailboxAddress("Admin", authorization.Email));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            var client = new SmtpClient();
            client.Connect(authorization.Host, authorization.Port, false);
            client.Authenticate(authorization.Email, authorization.Password);
            client.Send(emailMessage);
            client.Disconnect(true);
        }
    }
}
