using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.LcswPay
{
    /// <summary>
    /// 利楚商务扫呗支付客户端
    /// </summary>
    public interface ILcswPayClient
    {

        /// <summary>
        /// 执行WeChatPay API请求。
        /// </summary>
        /// <param name="request">具体的WeChatPay API请求</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(ILcswPayResquest<T> request) where T : LcswPayResponse;

        /// <summary>
        /// 执行WeChatPay API请求。
        /// </summary>
        /// <param name="request">具体的WeChatPay API请求</param>
        /// <param name="optionsName">配置选项名称</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(ILcswPayResquest<T> request, string optionsName) where T : LcswPayResponse;
    }
}
