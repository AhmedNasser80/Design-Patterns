using Adapter_DP.business_logic;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

namespace Adapter_DP
{
    public class ObjectAdapter : IUserNotificationService
    {
        private readonly SendGridClient client;

        public ObjectAdapter(SendGridClient client)
        {
            this.client = client;
        }

        public Task NotifyUser(string userId, string message)
        {
            return client.SendEmailAsync(new SendGridMessage());
        }
    }
}
