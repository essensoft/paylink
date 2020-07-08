using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.Alipay
{
    /// <summary>
    /// Alipay 客户端
    /// </summary>
    public interface IAlipayClient
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

        /// <summary>
        /// 执行 Alipay API请求。
        /// </summary>
        /// <param name="request">请求对象</param>
        /// <param name="options">配置选项</param>
        /// <param name="accessToken">用户授权token</param>
        /// <param name="appAuthToken">三方应用授权token</param>
        /// <param name="targetAppId">目标AppId，调用SPI三方能力API时需要传递此参数</param>
        /// <returns>响应对象</returns>
        Task<T> ExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options, string accessToken, string appAuthToken, string targetAppId) where T : AlipayResponse;

        /// <summary>
        /// 执行 Alipay API请求。
        /// </summary>
        /// <param name="request">请求对象</param>
        /// <param name="options">配置选项</param>
        Task<T> CertificateExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options) where T : AlipayResponse;

        /// <summary>
        /// 执行 Alipay API请求。
        /// </summary>
        /// <param name="request">请求对象</param>
        /// <param name="options">配置选项</param>
        /// <param name="accessToken">用户授权token</param>
        /// <returns>响应对象</returns>
        Task<T> CertificateExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options, string accessToken) where T : AlipayResponse;

        /// <summary>
        /// 执行 Alipay API请求。
        /// </summary>
        /// <param name="request">请求对象</param>
        /// <param name="options">配置选项</param>
        /// <param name="accessToken">用户授权token</param>
        /// <param name="appAuthToken">三方应用授权token</param>
        /// <returns>响应对象</returns>
        Task<T> CertificateExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options, string accessToken, string appAuthToken) where T : AlipayResponse;

        /// <summary>
        /// 执行 Alipay API请求。
        /// </summary>
        /// <param name="request">请求对象</param>
        /// <param name="options">配置选项</param>
        /// <param name="accessToken">用户授权token</param>
        /// <param name="appAuthToken">三方应用授权token</param>
        /// <param name="targetAppId">目标AppId，调用SPI三方能力API时需要传递此参数</param>
        /// <returns>响应对象</returns>
        Task<T> CertificateExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options, string accessToken, string appAuthToken, string targetAppId) where T : AlipayResponse;

        /// <summary>
        /// 执行 Alipay API请求。
        /// </summary>
        /// <param name="request">请求对象</param>
        /// <param name="options">配置选项</param>
        /// <returns>响应对象</returns>
        Task<T> PageExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options) where T : AlipayResponse;

        /// <summary>
        /// 执行 Alipay API请求。
        /// </summary>
        /// <param name="request">请求对象</param>
        /// <param name="options">配置选项</param>
        /// <param name="accessToken">用户会话码</param>
        /// <param name="reqMethod">请求访问方法</param>
        /// <returns>响应对象</returns>
        Task<T> PageExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options, string accessToken, string reqMethod) where T : AlipayResponse;

        /// <summary>
        /// 执行 Alipay API请求。
        /// </summary>
        /// <param name="request">请求对象</param>
        /// <param name="options">配置选项</param>
        /// <param name="accessToken">用户会话码</param>
        /// <param name="reqMethod">请求访问方法</param>
        /// <param name="appAuthToken">三方应用授权token</param>
        /// <returns>响应对象</returns>
        Task<T> PageExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options, string accessToken, string appAuthToken, string reqMethod) where T : AlipayResponse;


        /// <summary>
        /// 执行 Alipay API请求。
        /// </summary>
        /// <param name="request">请求对象</param>
        /// <param name="options">配置选项</param>
        /// <returns>响应对象</returns>
        Task<T> SdkExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options) where T : AlipayResponse;

        /// <summary>
        /// 执行 Alipay API请求。
        /// </summary>
        /// <param name="request">请求对象</param>
        /// <param name="options">配置选项</param>
        /// <param name="appAuthToken">三方应用授权token</param>
        /// <returns>响应对象</returns>
        Task<T> SdkExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options, string appAuthToken) where T : AlipayResponse;
    }
}
