using Essensoft.AspNetCore.Alipay.Request;
using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Alipay
{
    /// <summary>
    /// Alipay客户端。
    /// </summary>
    public interface IAlipayClient
    {
        /// <summary>
        /// 执行Alipay公开API请求。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">具体的Alipay API请求</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(IAlipayRequest<T> request) where T : AlipayResponse;

        /// <summary>
        /// 执行Alipay隐私API请求。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">具体的Alipay API请求</param>
        /// <param name="session">用户会话码</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(IAlipayRequest<T> request, string session) where T : AlipayResponse;

        /// <summary>
        /// 执行Alipay隐私API请求。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">具体的Alipay API请求</param>
        /// <param name="session">用户会话码</param>
        /// <param name="appAuthToken">应用授权码</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(IAlipayRequest<T> request, string session, string appAuthToken) where T : AlipayResponse;

        /// <summary>
        /// 执行Alipay公开API请求。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">具体的Alipay API请求</param>
        /// <returns>领域对象</returns>
        Task<T> PageExecuteAsync<T>(IAlipayRequest<T> request) where T : AlipayResponse;

        /// <summary>
        /// 执行Alipay隐私API请求。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">具体的Alipay API请求</param>
        /// <param name="session">用户会话码</param>
        /// <returns>领域对象</returns>
        Task<T> PageExecuteAsync<T>(IAlipayRequest<T> request, string session, string reqMethod) where T : AlipayResponse;

        /// <summary>
        /// 执行Alipay公开API请求。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">具体的Alipay API请求</param>
        /// <returns>领域对象</returns>
        Task<T> SdkExecuteAsync<T>(IAlipayRequest<T> request) where T : AlipayResponse;
    }
}
