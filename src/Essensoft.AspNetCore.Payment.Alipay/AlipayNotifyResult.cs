#if NETCOREAPP3_1

using Microsoft.AspNetCore.Mvc;

namespace Essensoft.AspNetCore.Payment.Alipay
{
    /// <summary>
    /// Alipay 通知响应
    /// </summary>
    public static class AlipayNotifyResult
    {
        private static readonly ContentResult _success = new ContentResult { Content = "success", ContentType = "text/plain", StatusCode = 200 };
        private static readonly ContentResult _failure = new ContentResult { Content = "failure", ContentType = "text/plain", StatusCode = 200 };

        /// <summary>
        /// 成功
        /// </summary>
        public static IActionResult Success => _success;

        /// <summary>
        /// 失败
        /// </summary>
        public static IActionResult Failure => _failure;
    }
}

#endif
