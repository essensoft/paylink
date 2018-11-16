using Microsoft.AspNetCore.Mvc;

namespace WebApplicationSample
{
    public class JDPayNotifyResult
    {
        private static readonly ContentResult _success = new ContentResult() { Content = "success", ContentType = "text/plain" };
        private static readonly ContentResult _ok = new ContentResult() { Content = "ok", ContentType = "text/plain" };

        public static IActionResult Success => _success;

        public static IActionResult Ok => _ok;
    }
}
