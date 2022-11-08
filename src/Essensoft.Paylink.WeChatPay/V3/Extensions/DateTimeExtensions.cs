using System;

namespace Essensoft.Paylink.WeChatPay.V3.Extensions;

public static class DateTimeExtensions
{
    /// <summary>
    /// 示例值：2018-06-08T10:34:56+08:00
    /// </summary>
    private const string Rfc3339Format = "yyyy-MM-ddTHH:mm:ssK";

    public static string ToRfc3339FormatString(this DateTime dateTime)
    {
        return dateTime.ToString(Rfc3339Format);
    }
}
