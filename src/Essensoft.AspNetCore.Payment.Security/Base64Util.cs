using System;

namespace Essensoft.AspNetCore.Payment.Security
{
    public static class Base64Util
    {
        public static bool IsBase64String(string str)
        {
            Span<byte> buffer = stackalloc byte[str.Length];
            return Convert.TryFromBase64String(str, buffer, out _);
        }
    }
}
