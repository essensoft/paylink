using System;
using System.Text;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Security;

namespace Essensoft.AspNetCore.Payment.Security
{
    public class SM3
    {
        public static string Compute(string data)
        {
            var digest = new SM3Digest();
            var bytes = Encoding.UTF8.GetBytes(data);
            digest.BlockUpdate(bytes, 0, bytes.Length);
            var result = DigestUtilities.DoFinal(digest);
            return BitConverter.ToString(result).Replace("-", "").ToLower();
        }
    }
}
