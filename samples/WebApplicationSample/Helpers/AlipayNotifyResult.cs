using Microsoft.AspNetCore.Mvc;

namespace WebApplicationSample.Helpers
{
    public class AlipayNotifyResult
    {
        private static readonly ContentResult _success = new ContentResult { Content = "success", ContentType = "text/plain" };

        public static IActionResult Success => _success;
    }
}
