#if NETCOREAPP3_1_OR_GREATER

using Microsoft.AspNetCore.Mvc;

namespace Essensoft.Paylink.WeChatPay.V3
{
    /// <summary>
    /// WeChatPay V3 通知应答
    /// </summary>
    public static class WeChatPayNotifyResult
    {
        private static readonly ContentResult success = new() { Content = "{\"code\":\"SUCCESS\",\"message\":\"SUCCESS\"}", ContentType = "application/json", StatusCode = 200 };
        private static readonly ContentResult failure = new() { Content = "{\"code\":\"FAIL\",\"message\":\"FAIL\"}", ContentType = "application/json", StatusCode = 500 };

        /// <summary>
        /// 成功
        /// </summary>
        public static IActionResult Success => success;

        /// <summary>
        /// 失败
        /// </summary>
        public static IActionResult Failure => failure;
    }
}

#endif
