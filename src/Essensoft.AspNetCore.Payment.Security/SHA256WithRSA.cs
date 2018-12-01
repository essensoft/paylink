using System;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;

namespace Essensoft.AspNetCore.Payment.Security
{
    public class SHA256WithRSA
    {
        public static string SignData(string data, ICipherParameters key)
        {
            var signer = SignerUtilities.GetSigner("SHA256WithRSA");
            signer.Init(true, key);
            var bytes = Encoding.UTF8.GetBytes(data);
            signer.BlockUpdate(bytes, 0, bytes.Length);
            return Convert.ToBase64String(signer.GenerateSignature());
        }

        public static bool VerifyData(string data, string sign, ICipherParameters key)
        {
            var verifier = SignerUtilities.GetSigner("SHA256WithRSA");
            verifier.Init(false, key);
            var bytes = Encoding.UTF8.GetBytes(data);
            verifier.BlockUpdate(bytes, 0, bytes.Length);
            return verifier.VerifySignature(Convert.FromBase64String(sign));
        }
    }
}
