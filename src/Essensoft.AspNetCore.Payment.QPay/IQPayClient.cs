using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.QPay
{
    public interface IQPayClient
    {
        /// <summary>
        /// 执行QPay API请求。
        /// </summary>
        /// <param name="request">具体的QPay API请求</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(IQPayRequest<T> request) where T : QPayResponse;

        /// <summary>
        /// 执行QPay Certificate API请求。
        /// </summary>
        /// <param name="request">具体的QPay Certificate API请求</param>
        /// <param name="certificateName">请求所使用证书的名称</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(IQPayCertificateRequest<T> request, string certificateName) where T : QPayResponse;
    }
}
