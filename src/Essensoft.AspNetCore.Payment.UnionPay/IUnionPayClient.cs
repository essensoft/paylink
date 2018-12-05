using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.UnionPay
{
    /// <summary>
    /// UnionPay 客户端。
    /// </summary>
    public interface IUnionPayClient
    {
        /// <summary>
        /// 执行UnionPay API请求。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">具体的UnionPay API请求</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(IUnionPayRequest<T> request) where T : UnionPayResponse;

        /// <summary>
        /// 执行UnionPay API请求。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">具体的UnionPay API请求</param>
        /// <param name="optionsName">配置选项名称</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(IUnionPayRequest<T> request, string optionsName) where T : UnionPayResponse;

        /// <summary>
        /// 执行UnionPay API请求。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">具体的UnionPay API请求</param>
        /// <returns>领域对象</returns>
        Task<T> PageExecuteAsync<T>(IUnionPayRequest<T> request) where T : UnionPayResponse;

        /// <summary>
        /// 执行UnionPay API请求。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">具体的UnionPay API请求</param>
        /// <param name="optionsName">配置选项名称</param>
        /// <param name="reqMethod">请求类型(POST/GET)</param>
        /// <returns>领域对象</returns>
        Task<T> PageExecuteAsync<T>(IUnionPayRequest<T> request, string optionsName) where T : UnionPayResponse;
    }
}
