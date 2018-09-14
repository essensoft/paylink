using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    public interface IWeChatPayNotifyClient
    {
        Task<T> ExecuteAsync<T>(HttpRequest request) where T : WeChatPayNotifyResponse;
    }
}
