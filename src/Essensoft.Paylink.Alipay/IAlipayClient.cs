using System.Collections.Generic;
using System.Threading.Tasks;

namespace Essensoft.Paylink.Alipay
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

#if NETCOREAPP3_1 || NET5_0
        /// <summary>
        /// 执行 Alipay 通知请求解析。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">控制器的请求</param>
        /// <param name="options">配置选项</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(Microsoft.AspNetCore.Http.HttpRequest request, AlipayOptions options) where T : AlipayNotify;

        /// <summary>
        /// 执行 Alipay 通知请求解析。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">控制器的请求</param>
        /// <param name="options">配置选项</param>
        /// <returns>领域对象</returns>
        Task<T> CertificateExecuteAsync<T>(Microsoft.AspNetCore.Http.HttpRequest request, AlipayOptions options) where T : AlipayNotify;

        /// <summary>
        /// 获取通知参数
        /// </summary>
        /// <param name="request"></param>
        Task<IDictionary<string, string>> GetParametersAsync(Microsoft.AspNetCore.Http.HttpRequest request);
#endif

        /// <summary>
        /// 执行 Alipay 通知请求解析。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="parameters">通知参数</param>
        /// <param name="options">配置选项</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(IDictionary<string, string> parameters, AlipayOptions options) where T : AlipayNotify;

        /// <summary>
        /// 执行 Alipay 通知请求解析。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="parameters">通知参数</param>
        /// <param name="options">配置选项</param>
        /// <returns>领域对象</returns>
        Task<T> CertificateExecuteAsync<T>(IDictionary<string, string> parameters, AlipayOptions options) where T : AlipayNotify;
    }
}
