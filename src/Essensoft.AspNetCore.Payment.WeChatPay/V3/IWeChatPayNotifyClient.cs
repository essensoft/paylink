using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3
{
    /// <summary>
    /// WeChatPay 通知客户端
    /// </summary>
    public interface IWeChatPayNotifyClient
    {
#if NETCOREAPP3_1
        /// <summary>
        /// 执行 WeChatPay V3 通知请求解析
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">控制器的请求</param>
        /// <param name="options">配置选项</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteV3Async<T>(Microsoft.AspNetCore.Http.HttpRequest request, WeChatPayOptions options) where T : WeChatPayNotify;
#endif
        /// <summary>
        /// 执行 WeChatPay V3 通知请求解析
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="body">通知内容</param>
        /// <param name="serial">Wechatpay_Serial</param>
        /// <param name="timestamp">Wechatpay_Timestamp</param>
        /// <param name="nonce">Wechatpay_Nonce</param>
        /// <param name="signature">Wechatpay_Signature</param>
        /// <param name="options">配置选项</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteV3Async<T>(string body, string serial, string timestamp, string nonce, string signature, WeChatPayOptions options) where T : WeChatPayNotify;
    }
}
