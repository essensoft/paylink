using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    public interface IWeChatPayClient
    {
        /// <summary>
        /// 执行 WeChatPay API请求。
        /// </summary>
        /// <param name="request">具体的WeChatPay API请求</param>
        /// <param name="options">配置选项</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(IWeChatPayRequest<T> request, WeChatPayOptions options) where T : WeChatPayResponse;

        /// <summary>
        /// 执行 WeChatPay API请求。
        /// </summary>
        /// <param name="request">具体的WeChatPay API请求</param>
        /// <param name="options">配置选项</param>
        /// <returns>领域对象</returns>
        Task<T> PageExecuteAsync<T>(IWeChatPayRequest<T> request, WeChatPayOptions options) where T : WeChatPayResponse;

        /// <summary>
        /// 执行 WeChatPay API证书请求。
        /// </summary>
        /// <param name="request">具体的WeChatPay API证书请求</param>
        /// <param name="options">配置选项</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(IWeChatPayCertRequest<T> request, WeChatPayOptions options) where T : WeChatPayResponse;

        /// <summary>
        /// 执行 WeChatPay Sdk请求。
        /// </summary>
        /// <param name="request">具体的WeChatPay Sdk请求</param>
        /// <param name="options">配置选项</param>
        Task<WeChatPayDictionary> ExecuteAsync(IWeChatPaySdkRequest request, WeChatPayOptions options);

        /// <summary>
        /// 执行 WeChatPay APIv3 Get请求。
        /// </summary>
        /// <param name="request">具体的WeChatPay APIv3 Get请求</param>
        /// <param name="options">配置选项</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(IWeChatPayV3GetRequest<T> request, WeChatPayOptions options) where T : WeChatPayV3Response;

        /// <summary>
        /// 执行 WeChatPay APIv3 Post请求。
        /// </summary>
        /// <param name="request">具体的WeChatPay APIv3 Post请求</param>
        /// <param name="options">配置选项</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(IWeChatPayV3PostRequest<T> request, WeChatPayOptions options) where T : WeChatPayV3Response;
    }
}
