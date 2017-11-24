using System.Threading.Tasks;

namespace Essensoft.AspNetCore.JdPay
{
    public interface IJdPayClient
    {
        /// <summary>
        /// 执行JdPay API请求。
        /// </summary>
        /// <param name="request">具体的JdPay API请求</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(IJdPayRequest<T> request) where T : JdPayResponse;
    }
}
