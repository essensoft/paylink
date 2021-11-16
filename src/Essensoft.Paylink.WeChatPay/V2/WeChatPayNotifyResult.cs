#if NETCOREAPP3_1_OR_GREATER

using Microsoft.AspNetCore.Mvc;

namespace Essensoft.Paylink.WeChatPay.V2
{
    /// <summary>
    /// WeChatPay V2 通知应答
    /// </summary>
    public static class WeChatPayNotifyResult
    {
        private static readonly ContentResult success = new() { Content = "<xml><return_code><![CDATA[SUCCESS]]></return_code><return_msg><![CDATA[SUCCESS]]></return_msg></xml>", ContentType = "text/xml", StatusCode = 200 };
        private static readonly ContentResult failure = new() { Content = "<xml><return_code><![CDATA[FAIL]]></return_code><return_msg><![CDATA[FAIL]]></return_msg></xml>", ContentType = "text/xml", StatusCode = 200 };

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
