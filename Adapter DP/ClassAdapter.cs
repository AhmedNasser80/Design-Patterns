using Adapter_DP.business_logic;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

namespace Adapter_DP
{
    public class ClassAdapter : SendGridClient, IUserNotificationService
    {
        public ClassAdapter(SendGridClientOptions options) : base(options)
        {
        }

        public Task NotifyUser(string userId, string message)
        {
            return SendEmailAsync(new SendGridMessage());
        }
    }
}
