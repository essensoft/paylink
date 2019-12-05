#if NETCOREAPP3_1

using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Essensoft.AspNetCore.Payment.Alipay
{
    /// <summary>
    /// Alipay 通知解析客户端。
    /// </summary>
    public interface IAlipayNotifyClient
    {
        /// <summary>
        /// 执行 Alipay 通知请求解析。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">控制器的请求</param>
        /// <param name="options">配置选项</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(HttpRequest request, AlipayOptions options) where T : AlipayNotify;
    }
}

#endif