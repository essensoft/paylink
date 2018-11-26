using Microsoft.AspNetCore.Mvc;

namespace WebApplicationSample.Helpers
{
    public class LianLianPayNotifyResult
    {
        private static readonly ContentResult _success = new ContentResult { Content = "{\"ret_code\":\"0000\",\"ret_msg\":\"交易成功\"}", ContentType = "application/json" };

        public static IActionResult Success => _success;
    }
}
