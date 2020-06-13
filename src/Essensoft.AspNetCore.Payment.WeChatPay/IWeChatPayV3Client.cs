using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    public interface IWeChatPayV3Client
    {
        /// <summary>
        /// 执行 WeChatPay V3 Sdk请求。
        /// </summary>
        /// <param name="request">具体的WeChatPay V3 Sdk请求</param>
        /// <param name="options">配置选项</param>
        Task<WeChatPayDictionary> ExecuteAsync(IWeChatPayV3SdkRequest request, WeChatPayOptions options);

        /// <summary>
        /// 执行 WeChatPay V3 Get请求。
        /// </summary>
        /// <param name="request">具体的WeChatPay V3 Get请求</param>
        /// <param name="options">配置选项</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(IWeChatPayV3GetRequest<T> request, WeChatPayOptions options) where T : WeChatPayV3Response;

        /// <summary>
        /// 执行 WeChatPay V3 Post请求。
        /// </summary>
        /// <param name="request">具体的WeChatPay V3 Post请求</param>
        /// <param name="options">配置选项</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(IWeChatPayV3PostRequest<T> request, WeChatPayOptions options) where T : WeChatPayV3Response;
    }
}
