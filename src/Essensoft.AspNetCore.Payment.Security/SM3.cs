using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Security;
using System;
using System.Text;

namespace Essensoft.AspNetCore.Security
{
    public class SM3
    {
        public static string Compute(string str)
        {
            var data = Encoding.UTF8.GetBytes(str);
            var digest = new SM3Digest();
            digest.BlockUpdate(data, 0, data.Length);
            var result = DigestUtilities.DoFinal(digest);
            return BitConverter.ToString(result).Replace("-", "").ToLower();
        }
    }
}
