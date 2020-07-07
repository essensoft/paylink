using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    public interface IWeChatPayNotifyClient
    {
        #region V2

#if NETCOREAPP3_1
        /// <summary>
        /// 执行 WeChatPay 通知请求解析
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">控制器的请求</param>
        /// <param name="options">配置选项</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteV2Async<T>(Microsoft.AspNetCore.Http.HttpRequest request, WeChatPayOptions options) where T : V2.WeChatPayNotify;
#endif
        /// <summary>
        /// 执行 WeChatPay 通知请求解析
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="body">通知内容</param>
        /// <param name="options">配置选项</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteV2Async<T>(string body, WeChatPayOptions options) where T : V2.WeChatPayNotify;

        #endregion

        #region V3

#if NETCOREAPP3_1
        /// <summary>
        /// 执行 WeChatPay V3通知请求解析
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">控制器的请求</param>
        /// <param name="options">配置选项</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteV3Async<T>(Microsoft.AspNetCore.Http.HttpRequest request, WeChatPayOptions options) where T : V3.WeChatPayNotify;
#endif
        /// <summary>
        /// 执行 WeChatPay V3通知请求解析
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="body">通知内容</param>
        /// <param name="serial">Wechatpay_Serial</param>
        /// <param name="timestamp">Wechatpay_Timestamp</param>
        /// <param name="nonce">Wechatpay_Nonce</param>
        /// <param name="signature">Wechatpay_Signature</param>
        /// <param name="options">配置选项</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteV3Async<T>(string body, string serial, string timestamp, string nonce, string signature, WeChatPayOptions options) where T : V3.WeChatPayNotify;

        #endregion
    }
}
