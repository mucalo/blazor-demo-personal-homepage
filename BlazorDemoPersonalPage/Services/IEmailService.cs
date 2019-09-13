using BlazorDemoPersonalPage.Models;

namespace BlazorDemoPersonalPage.Services
{
    public interface IEmailService
    {
        void SendEmail(EmailMessage message);
    }
}
