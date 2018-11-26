using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.QPay
{
    /// <summary>
    /// QPay客户端。
    /// </summary>
    public interface IQPayClient
    {
        /// <summary>
        /// 执行QPay API请求。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">具体的QPay API请求</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(IQPayRequest<T> request) where T : QPayResponse;

        /// <summary>
        /// 执行QPay API请求。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">具体的QPay API请求</param>
        /// <param name="optionsName">配置选项名称</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(IQPayRequest<T> request, string optionsName) where T : QPayResponse;

        /// <summary>
        /// 执行QPay API证书请求。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">具体的QPay API证书请求</param>
        /// <param name="certificateName">证书名称</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(IQPayCertificateRequest<T> request, string certificateName) where T : QPayResponse;

        /// <summary>
        /// 执行QPay API证书请求。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">具体的QPay API证书请求</param>
        /// <param name="optionsName">配置选项名称</param>
        /// <param name="certificateName">证书名称</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(IQPayCertificateRequest<T> request, string optionsName, string certificateName) where T : QPayResponse;
    }
}
