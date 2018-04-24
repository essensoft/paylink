using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    public interface IWeChatPayNotifyClient
    {
        Task<T> ExecuteAsync<T>(HttpRequest request) where T : WeChatPayNotifyResponse;
    }
}
