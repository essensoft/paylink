using Microsoft.AspNetCore.Http;
using System;
using System.Net.Http.Headers;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Utility
{
    public static class LianLianPayUtility
    {
        internal static bool HasTextJsonContentType(this HttpRequest request)
        {
            // Content-Type: text/json;charset=UTF-8
            MediaTypeHeaderValue.TryParse(request.ContentType, out var contentType);
            return contentType != null && contentType.MediaType.Equals("text/json", StringComparison.OrdinalIgnoreCase);
        }
    }
}
