using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.JDPay
{
    public interface IJDPayNotifyClient
    {
        Task<T> ExecuteAsync<T>(HttpRequest request) where T : JDPayNotifyResponse;
    }
}
