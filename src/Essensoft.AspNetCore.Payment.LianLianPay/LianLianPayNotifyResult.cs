using Microsoft.AspNetCore.Mvc;

namespace Essensoft.AspNetCore.Payment.LianLianPay
{
    /// <summary>
    /// 连连支付 - 通知应答
    /// </summary>
    public class LianLianPayNotifyResult
    {
        private static readonly ContentResult _success = new ContentResult { Content = "{\"ret_code\":\"0000\",\"ret_msg\":\"交易成功\"}", ContentType = "application/json", StatusCode = 200 };
        private static readonly ContentResult _failure = new ContentResult { Content = "{\"ret_code\":\"9999\",\"ret_msg\":\"交易失败\"}", ContentType = "application/json", StatusCode = 200 };

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
