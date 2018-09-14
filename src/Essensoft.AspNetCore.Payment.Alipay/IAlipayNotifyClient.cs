using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Essensoft.AspNetCore.Payment.Alipay
{
    /// <summary>
    /// Alipay通知客户端。
    /// </summary>
    public interface IAlipayNotifyClient
    {
        Task<T> ExecuteAsync<T>(HttpRequest request) where T : AlipayNotifyResponse;
    }
}
