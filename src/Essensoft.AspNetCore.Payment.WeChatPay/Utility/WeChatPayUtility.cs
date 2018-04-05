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
    }
}
