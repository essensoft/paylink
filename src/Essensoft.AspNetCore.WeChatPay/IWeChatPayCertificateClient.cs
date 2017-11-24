using System.Threading.Tasks;

namespace Essensoft.AspNetCore.WeChatPay
{
    public interface IWeChatPayCertificateClient
    {
        /// <summary>
        /// 执行WeChatPay API请求。
        /// </summary>
        /// <param name="request">具体的WeChatPay API请求</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(IWeChatPayCertificateRequest<T> request) where T : WeChatPayResponse;
    }
}
