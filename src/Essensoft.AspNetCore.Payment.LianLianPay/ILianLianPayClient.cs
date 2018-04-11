using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.LianLianPay
{
    public interface ILianLianPayClient
    {
        /// <summary>
        /// 执行LianLianPay API请求。
        /// </summary>
        /// <param name="request">具体的LianLianPay API请求</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(ILianLianPayRequest<T> request) where T : LianLianPayResponse;

        /// <summary>
        /// 执行LianLianPay API请求。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request">具体的LianLianPay API请求</param>
        /// <returns></returns>
        Task<T> PageExecuteAsync<T>(ILianLianPayRequest<T> request, string reqMethod) where T : LianLianPayResponse;
    }
}
