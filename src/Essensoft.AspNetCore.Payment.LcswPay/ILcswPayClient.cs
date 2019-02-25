using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.LcswPay
{
    /// <summary>
    /// 利楚商务扫呗支付客户端
    /// </summary>
    public interface ILcswPayClient
    {

        /// <summary>
        /// 执行利楚商务扫呗请求。
        /// </summary>
        /// <typeparam name="T">响应类型</typeparam>
        /// <param name="request">具体的扫呗请求</param>
        /// <returns>请求对象</returns>
        Task<T> ExecuteAsync<T>(ILcswPayResquest<T> request) where T : LcswPayResponse;

        /// <summary>
        /// 执行利楚商务扫呗请求。
        /// </summary>
        /// <typeparam name="T">响应类型</typeparam>
        /// <param name="request">具体的扫呗请求</param>
        /// <param name="optionsName">配置选项名称</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(ILcswPayResquest<T> request, string optionsName) where T : LcswPayResponse;
        /// <summary>
        /// 执行利楚商务扫呗请求
        /// </summary>
        /// <typeparam name="T">响应类型</typeparam>
        /// <param name="request">具体的扫呗请求</param>
        /// <param name="option">具体的配置项实例</param>
        /// <returns>响应实例</returns>
        Task<T> ExecuteAsync<T>(ILcswPayResquest<T> request, LcswPayOption option) where T : LcswPayResponse;
    }
}
