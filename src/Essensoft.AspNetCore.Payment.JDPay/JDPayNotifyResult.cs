#if NETCOREAPP3_1

using Microsoft.AspNetCore.Mvc;

namespace Essensoft.AspNetCore.Payment.JDPay
{
    /// <summary>
    /// JDPay 通知应答。
    /// </summary>
    public class JDPayNotifyResult
    {
        private static readonly ContentResult _success = new ContentResult { Content = "success", ContentType = "text/plain", StatusCode = 200 };
        private static readonly ContentResult _ok = new ContentResult { Content = "ok", ContentType = "text/plain", StatusCode = 200 };
        private static readonly ContentResult _failure = new ContentResult { Content = "failure", ContentType = "text/plain", StatusCode = 200 };

        /// <summary>
        /// 成功
        /// </summary>
        public static IActionResult Success => _success;

        /// <summary>
        /// 成功
        /// </summary>
        public static IActionResult Ok => _ok;

        /// <summary>
        /// 失败
        /// </summary>
        public static IActionResult Failure => _failure;
    }
}

#endif
