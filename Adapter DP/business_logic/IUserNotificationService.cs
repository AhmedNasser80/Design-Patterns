using System.Threading.Tasks;

namespace Adapter_DP.business_logic
{
    public interface IUserNotificationService
    {
        Task NotifyUser(string userId, string message);
    }
}
