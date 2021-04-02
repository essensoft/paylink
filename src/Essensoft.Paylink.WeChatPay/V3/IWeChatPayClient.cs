using System.Threading.Tasks;

namespace Essensoft.Paylink.WeChatPay.V3
{
    /// <summary>
    /// WeChatPay 客户端
    /// </summary>
    public interface IWeChatPayClient
    {
        /// <summary>
        /// 执行 WeChatPay V3 Sdk请求。
        /// </summary>
        /// <param name="request">请求对象</param>
        /// <param name="options">配置选项</param>
        /// <returns>响应字典</returns>
        Task<WeChatPayDictionary> ExecuteAsync(IWeChatPaySdkRequest request, WeChatPayOptions options);

        /// <summary>
        /// 执行 WeChatPay V3 Get请求。
        /// </summary>
        /// <param name="request">请求对象</param>
        /// <param name="options">配置选项</param>
        /// <returns>响应对象</returns>
        Task<T> ExecuteAsync<T>(IWeChatPayGetRequest<T> request, WeChatPayOptions options) where T : WeChatPayResponse;

        /// <summary>
        /// 执行 WeChatPay V3 Post请求。
        /// </summary>
        /// <param name="request">请求对象</param>
        /// <param name="options">配置选项</param>
        /// <returns>响应对象</returns>
        Task<T> ExecuteAsync<T>(IWeChatPayPostRequest<T> request, WeChatPayOptions options) where T : WeChatPayResponse;

        /// <summary>
        /// 执行 WeChatPay V3 Post敏感信息请求。
        /// </summary>
        /// <param name="request">请求对象</param>
        /// <param name="options">配置选项</param>
        /// <returns>响应对象</returns>
        Task<T> ExecuteAsync<T>(IWeChatPayPrivacyPostRequest<T> request, WeChatPayOptions options) where T : WeChatPayResponse;

#if NETCOREAPP3_1 || NET5_0
        /// <summary>
        /// 执行 WeChatPay V3 通知请求解析
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">控制器的请求</param>
        /// <param name="options">配置选项</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(Microsoft.AspNetCore.Http.HttpRequest request, WeChatPayOptions options) where T : WeChatPayNotify;
#endif
        /// <summary>
        /// 执行 WeChatPay V3 通知请求解析
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="headers">微信Http头信息</param>
        /// <param name="body">通知内容</param>
        /// <param name="options">配置选项</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(WeChatPayHeaders headers, string body, WeChatPayOptions options) where T : WeChatPayNotify;
    }
}
