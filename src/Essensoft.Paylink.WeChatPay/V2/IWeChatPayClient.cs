using System.Threading.Tasks;

namespace Essensoft.Paylink.WeChatPay.V2
{
    /// <summary>
    /// WeChatPay 客户端
    /// </summary>
    public interface IWeChatPayClient
    {
        /// <summary>
        /// 执行 WeChatPay V2 请求。
        /// </summary>
        /// <param name="request">请求对象</param>
        /// <param name="options">配置选项</param>
        /// <returns>响应对象</returns>
        Task<T> ExecuteAsync<T>(IWeChatPayRequest<T> request, WeChatPayOptions options) where T : WeChatPayResponse;

        /// <summary>
        /// 执行 WeChatPay V2 请求。
        /// </summary>
        /// <param name="request">请求对象</param>
        /// <param name="options">配置选项</param>
        /// <returns>响应对象</returns>
        Task<T> PageExecuteAsync<T>(IWeChatPayRequest<T> request, WeChatPayOptions options) where T : WeChatPayResponse;

        /// <summary>
        /// 执行 WeChatPay V2 证书请求。
        /// </summary>
        /// <param name="request">请求对象</param>
        /// <param name="options">配置选项</param>
        /// <returns>响应对象</returns>
        Task<T> ExecuteAsync<T>(IWeChatPayCertRequest<T> request, WeChatPayOptions options) where T : WeChatPayResponse;

        /// <summary>
        /// 执行 WeChatPay V2 Sdk请求。
        /// </summary>
        /// <param name="request">请求对象</param>
        /// <param name="options">配置选项</param>
        /// <returns>响应字典</returns>
        Task<WeChatPayDictionary> ExecuteAsync(IWeChatPaySdkRequest request, WeChatPayOptions options);

#if NETCOREAPP3_1 || NET5_0
        /// <summary>
        /// 执行 WeChatPay V2 通知请求解析
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">控制器的请求</param>
        /// <param name="options">配置选项</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(Microsoft.AspNetCore.Http.HttpRequest request, WeChatPayOptions options) where T : WeChatPayNotify;
#endif
        /// <summary>
        /// 执行 WeChatPay V2 通知请求解析
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="body">通知内容</param>
        /// <param name="options">配置选项</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(string body, WeChatPayOptions options) where T : WeChatPayNotify;
    }
}
