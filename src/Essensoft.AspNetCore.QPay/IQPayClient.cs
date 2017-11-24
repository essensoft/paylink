using System.Threading.Tasks;

namespace Essensoft.AspNetCore.QPay
{
    public interface IQPayClient
    {
        /// <summary>
        /// 执行QPay API请求。
        /// </summary>
        /// <param name="request">具体的QPay API请求</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(IQPayRequest<T> request) where T : QPayResponse;
    }
}
