using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.Alipay
{
    public interface IAlipayMobilePublicMultiMediaClient
    {
        /// <summary>
        /// 执行 Alipay API请求。
        /// </summary>
        /// <param name="request">请求对象</param>
        /// <param name="options">配置选项</param>
        /// <returns>响应对象</returns>
        Task<T> ExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options) where T : AlipayResponse;

        /// <summary>
        /// 执行 Alipay API请求。
        /// </summary>
        /// <param name="request">请求对象</param>
        /// <param name="options">配置选项</param>
        /// <param name="accessToken">用户授权token</param>
        /// <returns>响应对象</returns>
        Task<T> ExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options, string accessToken) where T : AlipayResponse;

        /// <summary>
        /// 执行 Alipay API请求。
        /// </summary>
        /// <param name="request">请求对象</param>
        /// <param name="options">配置选项</param>
        /// <param name="accessToken">用户授权token</param>
        /// <param name="appAuthToken">三方应用授权token</param>
        /// <returns>响应对象</returns>
        Task<T> ExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options, string accessToken, string appAuthToken) where T : AlipayResponse;
    }
}
