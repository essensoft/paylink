using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.JDPay
{
    public interface IJDPayClient
    {
        void SetTimeout(int timeout);

        /// <summary>
        /// 执行JDPay API请求。
        /// </summary>
        /// <param name="request">具体的JDPay API请求</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(IJDPayRequest<T> request) where T : JDPayResponse;

        /// <summary>
        /// 执行JDPay API请求。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request">具体的JDPay API请求</param>
        /// <returns></returns>
        Task<T> PageExecuteAsync<T>(IJDPayRequest<T> request) where T : JDPayResponse;

        /// <summary>
        /// 执行JDPay API请求。
        /// </summary>
        /// <param name="request">具体的JDPay API请求</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(IJDPayNPP10Request<T> request) where T : JDPayResponse;
    }
}
