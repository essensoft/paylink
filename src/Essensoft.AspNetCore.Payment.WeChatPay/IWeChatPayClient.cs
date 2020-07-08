using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    /// <summary>
    /// WeChatPay 客户端
    /// </summary>
    public interface IWeChatPayClient
    {
        #region V2

        /// <summary>
        /// 执行 WeChatPay V2 请求。
        /// </summary>
        /// <param name="request">请求对象</param>
        /// <param name="options">配置选项</param>
        /// <returns>响应对象</returns>
        Task<T> ExecuteAsync<T>(V2.IWeChatPayRequest<T> request, WeChatPayOptions options) where T : V2.WeChatPayResponse;

        /// <summary>
        /// 执行 WeChatPay V2 请求。
        /// </summary>
        /// <param name="request">请求对象</param>
        /// <param name="options">配置选项</param>
        /// <returns>响应对象</returns>
        Task<T> PageExecuteAsync<T>(V2.IWeChatPayRequest<T> request, WeChatPayOptions options) where T : V2.WeChatPayResponse;

        /// <summary>
        /// 执行 WeChatPay V2 证书请求。
        /// </summary>
        /// <param name="request">请求对象</param>
        /// <param name="options">配置选项</param>
        /// <returns>响应对象</returns>
        Task<T> ExecuteAsync<T>(V2.IWeChatPayCertRequest<T> request, WeChatPayOptions options) where T : V2.WeChatPayResponse;

        /// <summary>
        /// 执行 WeChatPay V2 Sdk请求。
        /// </summary>
        /// <param name="request">请求对象</param>
        /// <param name="options">配置选项</param>
        /// <returns>响应字典</returns>
        Task<WeChatPayDictionary> ExecuteAsync(V2.IWeChatPaySdkRequest request, WeChatPayOptions options);

        #endregion

        #region V3

        /// <summary>
        /// 执行 WeChatPay V3 Sdk请求。
        /// </summary>
        /// <param name="request">请求对象</param>
        /// <param name="options">配置选项</param>
        /// <returns>响应字典</returns>
        Task<WeChatPayDictionary> ExecuteAsync(V3.IWeChatPaySdkRequest request, WeChatPayOptions options);

        /// <summary>
        /// 执行 WeChatPay V3 Get请求。
        /// </summary>
        /// <param name="request">请求对象</param>
        /// <param name="options">配置选项</param>
        /// <returns>响应对象</returns>
        Task<T> ExecuteAsync<T>(V3.IWeChatPayGetRequest<T> request, WeChatPayOptions options) where T : V3.WeChatPayResponse;

        /// <summary>
        /// 执行 WeChatPay V3 Post请求。
        /// </summary>
        /// <param name="request">请求对象</param>
        /// <param name="options">配置选项</param>
        /// <returns>响应对象</returns>
        Task<T> ExecuteAsync<T>(V3.IWeChatPayPostRequest<T> request, WeChatPayOptions options) where T : V3.WeChatPayResponse;

        #endregion
    }
}
