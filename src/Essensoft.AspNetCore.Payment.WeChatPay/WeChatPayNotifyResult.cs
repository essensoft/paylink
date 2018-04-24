using Microsoft.AspNetCore.Mvc;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    public class WeChatPayNotifyResult
    {
        private static readonly ContentResult _success = new ContentResult() { Content = "<xml><return_code><![CDATA[SUCCESS]]></return_code></xml>", ContentType = "text/xml" };

        public static IActionResult Success => _success;
    }
}
