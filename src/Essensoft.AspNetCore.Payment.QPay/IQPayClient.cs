using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.QPay
{
    public interface IQPayClient
    {
        /// <summary>
        /// 执行 QPay API请求。
        /// </summary>
        /// <param name="request">具体的QPay API请求</param>
        /// <param name="options">配置选项</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(IQPayRequest<T> request, QPayOptions options) where T : QPayResponse;

        /// <summary>
        /// 执行 QPay API证书请求。
        /// </summary>
        /// <param name="request">具体的QPay API证书请求</param>
        /// <param name="options">配置选项</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(IQPayCertRequest<T> request, QPayOptions options) where T : QPayResponse;
    }
}
