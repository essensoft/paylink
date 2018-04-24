using Microsoft.AspNetCore.Http;
using System;
using System.Net.Http.Headers;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Utility
{
    public static class WeChatPayUtility
    {
        internal static bool HasTextJsonContentType(this HttpRequest request)
        {
            // Content-Type: text/json;charset=UTF-8
            MediaTypeHeaderValue.TryParse(request.ContentType, out var contentType);
            return contentType != null && contentType.MediaType.Equals("text/json", StringComparison.OrdinalIgnoreCase);
        }

        public static string GetTimeStamp()
        {
            var ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds).ToString();
        }
    }
}
