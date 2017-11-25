using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Essensoft.AspNetCore.Security
{
    public class Md5
    {
        public static string GetMD5WithKey(SortedDictionary<string, string> parameters, string key, bool excludeSignType = true)
        {
            var content = new StringBuilder();
            foreach (var iter in parameters)
            {
                if (!string.IsNullOrEmpty(iter.Value) && iter.Key != "sign" && (excludeSignType ? iter.Key != "sign_type" : true))
                    content.Append(iter.Key).Append('=').Append(iter.Value).Append("&");
            }
            var signContent = content.Append("key=").Append(key).ToString();
            return GetMD5(signContent).ToUpper();
        }

        public static string GetMD5(string encypStr)
        {
            using (var md5 = MD5.Create())
            {
                var hsah = md5.ComputeHash(Encoding.UTF8.GetBytes(encypStr));
                return BitConverter.ToString(hsah).Replace("-", "");
            }
        }
    }
}
