using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.LianLianPay
{
    /// <summary>
    /// LianLianPay 客户端。
    /// </summary>
    public interface ILianLianPayClient
    {
        /// <summary>
        /// 执行LianLianPay API请求。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">具体的LianLianPay API请求</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(ILianLianPayRequest<T> request) where T : LianLianPayResponse;

        /// <summary>
        /// 执行LianLianPay API请求。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">具体的LianLianPay API请求</param>
        /// <param name="optionsName">配置选项名称</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(ILianLianPayRequest<T> request, string optionsName) where T : LianLianPayResponse;
    }
}
