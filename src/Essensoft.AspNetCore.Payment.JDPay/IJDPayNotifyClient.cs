using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Essensoft.AspNetCore.Payment.JDPay
{
    public interface IJDPayNotifyClient
    {
        Task<T> ExecuteAsync<T>(HttpRequest request) where T : JDPayNotifyResponse;
    }
}
