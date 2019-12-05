using System;
using System.Collections;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Essensoft.AspNetCore.Payment.Security;
using Org.BouncyCastle.Cms;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Operators;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509.Store;
using SHA1 = Essensoft.AspNetCore.Payment.Security.SHA1;
using SHA256 = Essensoft.AspNetCore.Payment.Security.SHA256;
using X509Certificate = Org.BouncyCastle.X509.X509Certificate;

namespace Essensoft.AspNetCore.Payment.JDPay.Utility
{
    /// <summary>
    /// JDPay 安全类。
    /// </summary>
    public static class JDPaySecurity
    {
        private const int MAX_MSG_LENGTH = 16 * 1024;
        private static readonly byte[] iv = { 1, 2, 3, 4, 5, 6, 7, 8 };

        public static string GetSignContent(JDPayDictionary dictionary)
        {
            if (dictionary == null || dictionary.Count == 0)
            {
                return string.Empty;
            }

            var sb = new StringBuilder();
            foreach (var iter in dictionary)
            {
                if (!string.IsNullOrEmpty(iter.Value) && iter.Key != "sign")
                {
                    sb.Append(iter.Key).Append("=").Append(iter.Value).Append("&");
                }
            }

            return sb.Remove(sb.Length - 1, 1).ToString();
        }

        private static string GetNPP10Sign(JDPayDictionary dictionary, string algorithm, string salt)
        {
            if (dictionary == null || dictionary.Count == 0)
            {
                return string.Empty;
            }

            var sb = new StringBuilder();
            foreach (var iter in dictionary)
            {
                if (!string.IsNullOrEmpty(iter.Value) && iter.Key != "sign_type" && iter.Key != "sign_data" && iter.Key != "encrypt_type" && iter.Key != "encrypt_data" && iter.Key != "salt")
                {
                    sb.Append(iter.Key).Append("=").Append(iter.Value).Append("&");
                }
            }

            var sign = string.Empty;
            var data = sb.Remove(sb.Length - 1, 1) + salt;

            if ("SHA" == algorithm)
            {
                sign = SHA1.Compute(data).ToUpper();
            }
            else if ("SHA-256" == algorithm)
            {
                sign = SHA256.Compute(data).ToUpper();
            }

            return sign;
        }

        private static string GetNPP10Sign(string content, string algorithm, string salt)
        {
            var sign = string.Empty;

            var data = content + salt;

            if ("SHA" == algorithm)
            {
                sign = SHA1.Compute(data);
            }
            else if ("SHA-256" == algorithm)
            {
                sign = SHA256.Compute(data);
            }

            return sign;
        }

        private static string GetNPP10SignContentOrEncryptContent(JDPayDictionary dictionary)
        {
            if (dictionary == null || dictionary.Count == 0)
            {
                return string.Empty;
            }

            var sb = new StringBuilder();
            foreach (var iter in dictionary)
            {
                if (!string.IsNullOrEmpty(iter.Value) && iter.Key != "sign_type" && iter.Key != "sign_data" && iter.Key != "encrypt_type" && iter.Key != "encrypt_data" && iter.Key != "salt")
                {
                    sb.Append(iter.Key).Append("=").Append(iter.Value).Append("&");
                }
            }

            return sb.Remove(sb.Length - 1, 1).ToString();
        }

        public static string RSASign(string sourceSignString, ICipherParameters privateKey)
        {
            var sha256SourceSignString = SHA256.Compute(sourceSignString);
            var newsks = RSA_ECB_PKCS1Padding.Encrypt(Encoding.UTF8.GetBytes(sha256SourceSignString), privateKey);
            return Convert.ToBase64String(newsks, Base64FormattingOptions.InsertLineBreaks);
        }

        public static bool RSACheckContent(string content, string sign, ICipherParameters publicKey)
        {
            var sha256SourceSignString = SHA256.Compute(content);
            var decryptArr = RSA_ECB_PKCS1Padding.Decrypt(Convert.FromBase64String(sign), publicKey);
            var decrypStr = Encoding.UTF8.GetString(decryptArr);
            return sha256SourceSignString.Equals(decrypStr);
        }

        public static string EncryptECB(string data, byte[] key)
        {
            var resultByte = InitResultByteArray(data);
            var desdata = Security.TripleDES.Encode(resultByte, key, iv, CipherMode.ECB, PaddingMode.Zeros);
            return BitConverter.ToString(desdata).Replace("-", "").ToLower();
        }

        public static string DecryptECB(string data, byte[] key)
        {
            var hexSourceData = Hex2byte(data);
            var unDesResult = Security.TripleDES.Decode(hexSourceData, key, iv, CipherMode.ECB, PaddingMode.Zeros);
            var dataSizeByte = new byte[4];
            dataSizeByte[0] = unDesResult[0];
            dataSizeByte[1] = unDesResult[1];
            dataSizeByte[2] = unDesResult[2];
            dataSizeByte[3] = unDesResult[3];
            var dsb = ByteArrayToInt(dataSizeByte, 0);
            if (dsb > MAX_MSG_LENGTH)
            {
                throw new JDPayException("msg over MAX_MSG_LENGTH or msg error");
            }
            var tempData = new byte[dsb];
            for (var i = 0; i < dsb; i++)
            {
                tempData[i] = unDesResult[4 + i];
            }
            var hexStr = BitConverter.ToString(tempData).Replace("-", "").ToLower();
            var str = Hex2bin(hexStr);
            return str;
        }

        public static byte[] InitResultByteArray(string data)
        {
            var source = Encoding.UTF8.GetBytes(data);
            var merchantData = source.Length;
            var x = (merchantData + 4) % 8;
            var y = x == 0 ? 0 : 8 - x;
            var resultByte = new byte[merchantData + 4 + y];
            resultByte[0] = (byte)((merchantData >> 24) & 0xFF);
            resultByte[1] = (byte)((merchantData >> 16) & 0xFF);
            resultByte[2] = (byte)((merchantData >> 8) & 0xFF);
            resultByte[3] = (byte)(merchantData & 0xFF);
            //4.填充补位数据
            for (var i = 0; i < merchantData; i++)
            {
                resultByte[4 + i] = source[i];
            }
            for (var i = 0; i < y; i++)
            {
                resultByte[merchantData + 4 + i] = 0x00;
            }

            return resultByte;
        }

        public static byte[] Hex2byte(string b)
        {
            if (b.Length % 2 != 0)
            {
                throw new JDPayException("长度不是偶数");
            }

            var b2 = new byte[b.Length / 2];
            for (var n = 0; n < b.Length; n += 2)
            {
                var item = b.Substring(n, 2);
                // 两位一组，表示一个字节,把这样表示的16进制字符串，还原成一个进制字节
                b2[n / 2] = (byte)Convert.ToInt32(item, 16);
            }

            return b2;
        }

        public static int ByteArrayToInt(byte[] b, int offset)
        {
            var value = 0;
            for (var i = 0; i < 4; i++)
            {
                var shift = (4 - 1 - i) * 8;
                value += (b[i + offset] & 0x000000FF) << shift;//往高位游
            }

            return value;
        }

        public static string Hex2bin(string hex)
        {
            var digital = "0123456789abcdef";
            var hex2char = hex.ToCharArray();
            var bytes = new byte[hex.Length / 2];
            for (var i = 0; i < bytes.Length; i++)
            {
                var temp = digital.IndexOf(hex2char[2 * i]) * 16;
                temp += digital.IndexOf(hex2char[2 * i + 1]);
                bytes[i] = (byte)(temp & 0xff);
            }

            return Encoding.UTF8.GetString(bytes);
        }

        public static string BytesToString(byte[] src)
        {
            var hexstring = "0123456789ABCDEF";
            var stringBuilder = new StringBuilder("");

            if (src == null || src.Length <= 0)
            {
                return null;
            }

            for (var i = 0; i < src.Length; i++)
            {
                var v = src[i] & 0xFF;
                var hv = Convert.ToString(v, 16);
                if (hv.Length < 2)
                {
                    stringBuilder.Append(0);
                }
                stringBuilder.Append(hv);
            }

            var srcStr = stringBuilder.ToString();
            var chars = srcStr.ToCharArray();
            var bytes = new byte[srcStr.Length / 2];
            for (var i = 0; i < bytes.Length; i++)
            {
                var temp = hexstring.IndexOf(chars[2 * i]) << 4;
                temp += hexstring.IndexOf(chars[2 * i + 1]);
                bytes[i] = (byte)(temp & 0xff);
            }

            return Encoding.UTF8.GetString(bytes);
        }

        public static bool VerifySign(JDPayDictionary dictionary, string key)
        {
            dictionary.TryGetValue(JDPayContants.SIGN_TYPE, out var algorithm);
            dictionary.TryGetValue(JDPayContants.SIGN_DATA, out var sign);
            dictionary.Remove(JDPayContants.SIGN_TYPE);
            dictionary.Remove(JDPayContants.SIGN_DATA);
            return Verify(sign, dictionary, algorithm, key);
        }

        private static bool Verify(string signStr, JDPayDictionary dictionary, string algorithm, string salt)
        {
            if (string.IsNullOrEmpty(signStr) || dictionary == null || dictionary.Count == 0)
            {
                return false;
            }
            var newsign = GetNPP10Sign(dictionary, algorithm, salt);
            return newsign == signStr;
        }

        public static JDPayDictionary EncryptData(string signCert, string password, string envelopCert, JDPayDictionary dictionary, string singKey, string encryptType, bool isEncrypt)
        {
            var encryptData = new JDPayDictionary();
            var data = GetNPP10SignContentOrEncryptContent(dictionary);

            dictionary.TryGetValue(JDPayContants.CUSTOMER_NO, out var customerNo);
            dictionary.TryGetValue(JDPayContants.SIGN_TYPE, out var signType);

            if (!isEncrypt || string.IsNullOrEmpty(encryptType))
            {
                dictionary.Add(JDPayContants.SIGN_DATA, GetNPP10Sign(data, signType, singKey));
                encryptData = dictionary;
            }
            else
            {
                encryptData.Add(JDPayContants.SIGN_TYPE, signType);
                encryptData.Add(JDPayContants.SIGN_DATA, GetNPP10Sign(data, signType, singKey));
                encryptData.Add(JDPayContants.CUSTOMER_NO, customerNo);
                encryptData.Add(JDPayContants.ENCRYPT_TYPE, encryptType);
                if ("RSA" == encryptType)
                {
                    encryptData.Add(JDPayContants.ENCRYPT_DATA, SignEnvelop(signCert, password, envelopCert, data));
                }
                else
                {
                    throw new JDPayException("不支持的加密方式");
                }
            }

            return encryptData;
        }

        private static string SignEnvelop(string signCert, string password, string envelopCert, string orgData)
        {
            var pkcs12StoreBuilder = new Pkcs12StoreBuilder();
            var pkcs12Store = pkcs12StoreBuilder.Build();
            pkcs12Store.Load(new MemoryStream(Convert.FromBase64String(signCert)), password.ToCharArray());

            var aliases = pkcs12Store.Aliases;
            var enumerator = aliases.GetEnumerator();
            enumerator.MoveNext();
            var alias = enumerator.Current.ToString();
            var privKey = pkcs12Store.GetKey(alias);

            var x509Cert = pkcs12Store.GetCertificate(alias).Certificate;
            var sha1Signer = SignerUtilities.GetSigner("SHA1withRSA");
            sha1Signer.Init(true, privKey.Key);

            var gen = new CmsSignedDataGenerator();
            gen.AddSignerInfoGenerator(new SignerInfoGeneratorBuilder().Build(new Asn1SignatureFactory("SHA1withRSA", privKey.Key), x509Cert));
            gen.AddCertificates(X509StoreFactory.Create("Certificate/Collection", new X509CollectionStoreParameters(new ArrayList { x509Cert })));

            var sigData = gen.Generate(new CmsProcessableByteArray(Encoding.UTF8.GetBytes(orgData)), true);
            var signData = sigData.GetEncoded();

            var certificate = DotNetUtilities.FromX509Certificate(new X509Certificate2(Convert.FromBase64String(envelopCert)));
            var rst = Convert.ToBase64String(EncryptEnvelop(certificate, signData));
            return rst;
        }

        private static byte[] EncryptEnvelop(X509Certificate certificate, byte[] bsOrgData)
        {
            var gen = new CmsEnvelopedDataGenerator();
            var data = new CmsProcessableByteArray(bsOrgData);
            gen.AddKeyTransRecipient(certificate);

            var enveloped = gen.Generate(data, CmsEnvelopedGenerator.DesEde3Cbc);
            var a = enveloped.ContentInfo.ToAsn1Object();
            return a.GetEncoded();
        }
    }
}
