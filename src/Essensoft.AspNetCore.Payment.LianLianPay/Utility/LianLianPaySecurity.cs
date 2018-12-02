using System;
using System.Collections.Generic;
using System.Text;
using Essensoft.AspNetCore.Payment.Security;
using Org.BouncyCastle.Crypto;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Utility
{
    public class LianLianPaySecurity
    {
        public static string GetSignContent(LianLianPayDictionary para, List<string> exclude = null)
        {
            if (para == null || para.Count == 0)
            {
                return string.Empty;
            }

            var sb = new StringBuilder();
            foreach (var iter in para)
            {
                if (exclude != null && exclude.Contains(iter.Key))
                {
                    continue;
                }

                if (!string.IsNullOrEmpty(iter.Value) && "sign" != iter.Key)
                {
                    sb.Append(iter.Key).Append("=").Append(iter.Value).Append("&");
                }
            }

            return sb.Remove(sb.Length - 1, 1).ToString();
        }

        public static string Encrypt(string plaintext, ICipherParameters public_key)
        {
            var hmack_key = Guid.NewGuid().ToString("N");
            var version = "lianpay1_0_1";
            var aes_key = Guid.NewGuid().ToString("N");
            var nonce = Guid.NewGuid().ToString("N").Substring(0, 8);
            return LianlianpayEncrypt(plaintext, public_key, hmack_key, version, aes_key, nonce);
        }

        public static string Decrypt(string ciphertext, ICipherParameters private_key)
        {
            if (!string.IsNullOrEmpty(ciphertext))
            {
                var ciphertextArry = ciphertext.Split('$');
                var base64_encrypted_aes_key = ciphertextArry.Length > 2 ? ciphertextArry[2] : string.Empty;
                var base64_nonce = ciphertextArry.Length > 3 ? ciphertextArry[3] : string.Empty;
                var base64_ciphertext = ciphertextArry.Length > 4 ? ciphertextArry[4] : string.Empty;
                return LianlianpayDecrypt(base64_ciphertext, base64_encrypted_aes_key, base64_nonce, private_key);
            }

            return string.Empty;
        }

        private static string LianlianpayEncrypt(string req, ICipherParameters public_key, string hmack_key, string version, string aes_key, string nonce)
        {
            var b64Hmack_key = RSA_ECB_OAEPWithSHA1AndMGF1Padding.Encrypt(hmack_key, public_key);
            var b64Aes_key = RSA_ECB_OAEPWithSHA1AndMGF1Padding.Encrypt(aes_key, public_key);
            var b64Nonce = Convert.ToBase64String(Encoding.UTF8.GetBytes(nonce));
            var iv = CreateCtrIv(Encoding.UTF8.GetBytes(nonce));
            var encry = AES_CTR_NoPadding.Encrypt(req, aes_key, iv);
            var message = b64Nonce + "$" + encry;
            var sign = HMACSHA256.Compute(Encoding.UTF8.GetBytes(message), Encoding.UTF8.GetBytes(hmack_key));
            var b64Sign = Convert.ToBase64String(sign);
            return version + "$" + b64Hmack_key + "$" + b64Aes_key + "$" + b64Nonce + "$" + encry + "$" + b64Sign;
        }

        private static string LianlianpayDecrypt(string base64_ciphertext, string base64_encrypted_aes_key, string base64_nonce, ICipherParameters trader_pri_key)
        {
            var key = RSA_ECB_OAEPWithSHA1AndMGF1Padding.Decrypt(base64_encrypted_aes_key, trader_pri_key);
            var nonce = Convert.FromBase64String(base64_nonce);
            var iv = CreateCtrIv(nonce);
            return AES_CTR_NoPadding.Decrypt(base64_ciphertext, key, iv);
        }

        private static byte[] CreateCtrIv(byte[] nonce)
        {
            var counter = new byte[] { 0, 0, 0, 0, 0, 0, 0, 1 };
            var output = new byte[nonce.Length + counter.Length];

            for (var i = 0; i < nonce.Length; ++i)
            {
                output[i] = nonce[i];
            }
            for (var i = 0; i < counter.Length; ++i)
            {
                output[i + nonce.Length] = counter[i];
            }

            return output;
        }
    }
}
