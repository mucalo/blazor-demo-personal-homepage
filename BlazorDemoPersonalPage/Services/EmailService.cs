using BlazorDemoPersonalPage.Models;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace BlazorDemoPersonalPage.Services
{
    public class EmailService : IEmailService
    {
        private readonly EmailSettings _emailSettings;
        public EmailService(IOptions<EmailSettings> settings)
        {
            _emailSettings = settings.Value;
        }

        public void SendEmail(EmailMessage message)
        {
            if (message != null)
            {
                using (var smtp = new SmtpClient())
                {
                    // Prepare SMTP params
                    smtp.Host = _emailSettings.SmtpServer;
                    smtp.Port = _emailSettings.Port;
                    smtp.Credentials = new NetworkCredential(_emailSettings.Username, _emailSettings.Password);
                    smtp.EnableSsl = _emailSettings.IsSSL;

                    // Prepare mail message
                    MailMessage mailMessage = new MailMessage();
                    foreach (var recipient in _emailSettings.Recipients)
                    {
                        mailMessage.To.Add(recipient);
                    }
                    mailMessage.Subject = _emailSettings.DefaultTitle;
                    mailMessage.From = new MailAddress(_emailSettings.Username, _emailSettings.SenderDisplayName);

                    // Prepare message body
                    StringBuilder sb = new StringBuilder();
                    sb.Append("Name: " + message.Name + "<br/>");
                    sb.Append("Email: " + message.Email + "<br/>");
                    sb.Append("Message: <br/>" + message.Message);

                    mailMessage.Body = sb.ToString();
                    mailMessage.IsBodyHtml = true;

                    try
                    {
                        smtp.Send(mailMessage);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(JsonConvert.SerializeObject(e));
                        throw e;
                    }
                }
            }
        }
    }
}
