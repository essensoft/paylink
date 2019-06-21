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
        /// <param name="options">配置选项</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(IUnionPayRequest<T> request, UnionPayOptions options) where T : UnionPayResponse;

        /// <summary>
        /// 执行UnionPay API请求。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">具体的UnionPay API请求</param>
        /// <param name="options">配置选项</param>
        /// <returns>领域对象</returns>
        Task<T> PageExecuteAsync<T>(IUnionPayRequest<T> request, UnionPayOptions options) where T : UnionPayResponse;
    }
}
