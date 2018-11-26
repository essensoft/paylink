using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    /// <summary>
    /// WeChatPay客户端。
    /// </summary>
    public interface IWeChatPayClient
    {
        /// <summary>
        /// 执行WeChatPay API请求。
        /// </summary>
        /// <param name="request">具体的WeChatPay API请求</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(IWeChatPayRequest<T> request) where T : WeChatPayResponse;

        /// <summary>
        /// 执行WeChatPay API请求。
        /// </summary>
        /// <param name="request">具体的WeChatPay API请求</param>
        /// <param name="optionsName">配置选项名称</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(IWeChatPayRequest<T> request, string optionsName) where T : WeChatPayResponse;

        /// <summary>
        /// 执行WeChatPay API证书请求。
        /// </summary>
        /// <param name="request">具体的WeChatPay API证书请求</param>
        /// <param name="certificateName">证书名称</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(IWeChatPayCertificateRequest<T> request, string certificateName) where T : WeChatPayResponse;

        /// <summary>
        /// 执行WeChatPay API证书请求。
        /// </summary>
        /// <param name="request">具体的WeChatPay API证书请求</param>
        /// <param name="optionsName">配置选项名称</param>
        /// <param name="certificateName">证书名称</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(IWeChatPayCertificateRequest<T> request, string optionsName, string certificateName) where T : WeChatPayResponse;

        /// <summary>
        /// 执行WeChatPay API调起请求。
        /// </summary>
        /// <param name="request">具体的WeChatPay API调起请求</param>
        /// <returns>领域对象</returns>
        Task<WeChatPayDictionary> ExecuteAsync(IWeChatPayCallRequest request);

        /// <summary>
        /// 执行WeChatPay API调起请求。
        /// </summary>
        /// <param name="request">具体的WeChatPay API调起请求</param>
        /// <param name="optionsName">配置选项名称</param>
        /// <returns>领域对象</returns>
        Task<WeChatPayDictionary> ExecuteAsync(IWeChatPayCallRequest request, string optionsName);
    }
}
