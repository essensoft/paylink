#if NETCOREAPP3_1

using Microsoft.AspNetCore.Mvc;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    /// <summary>
    /// WeChatPay 通知应答。
    /// </summary>
    public static class WeChatPayNotifyResult
    {
        private static readonly ContentResult _success = new ContentResult { Content = "<xml><return_code><![CDATA[SUCCESS]]></return_code></xml>", ContentType = "text/xml", StatusCode = 200 };
        private static readonly ContentResult _failure = new ContentResult { Content = "<xml><return_code><![CDATA[FAIL]]></return_code></xml>", ContentType = "text/xml", StatusCode = 200 };

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
