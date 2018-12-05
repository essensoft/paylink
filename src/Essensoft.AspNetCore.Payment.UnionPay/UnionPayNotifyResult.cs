using Microsoft.AspNetCore.Mvc;

namespace Essensoft.AspNetCore.Payment.UnionPay
{
    /// <summary>
    /// UnionPay 通知应答
    /// </summary>
    public class UnionPayNotifyResult
    {
        private static readonly ContentResult _success = new ContentResult { StatusCode = 200 };
        private static readonly ContentResult _failure = new ContentResult { StatusCode = 202 };

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
