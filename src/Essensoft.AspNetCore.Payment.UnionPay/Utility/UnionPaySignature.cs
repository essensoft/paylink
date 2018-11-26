using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using Essensoft.AspNetCore.Payment.Security;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Pkix;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace Essensoft.AspNetCore.Payment.UnionPay.Utility
{
    public class UnionPaySignature
    {
        private static readonly string UNIONPAY_CNNAME = "中国银联股份有限公司";

        private static readonly Dictionary<string, X509Certificate> validateCerts = new Dictionary<string, X509Certificate>();

        public static void Sign(Dictionary<string, string> reqData, string certId, AsymmetricKeyParameter parameters, string secureKey)
        {
            if (!reqData.ContainsKey("signMethod"))
            {
                throw new Exception("signMethod must Not null");
            }

            var signMethod = reqData["signMethod"];
            if ("01".Equals(signMethod))
            {
                SignByCertInfo(reqData, certId, parameters);
            }
            else if ("11".Equals(signMethod) || "12".Equals(signMethod))
            {
                SignBySecureKey(reqData, secureKey);
            }
            else
            {
                throw new Exception("Error signMethod [" + signMethod + "] in Sign. ");
            }
        }

        public static bool Validate(Dictionary<string, string> data, X509Certificate rootCert, X509Certificate middleCert, string secureKey, bool ifValidateCNName)
        {
            if (!data.ContainsKey("signMethod") || !data.ContainsKey("signature") || !data.ContainsKey("version"))
            {
                return false;
            }

            var signMethod = data["signMethod"];
            var result = false;

            if ("01".Equals(signMethod))
            {
                var signValue = data["signature"];
                data.Remove("signature");

                var stringData = GetSignContent(data, true, false);
                var stringSignDigest = SHA256.Compute(stringData);
                var signPubKeyCert = data["signPubKeyCert"];

                var cert = VerifyAndGetPubKey(signPubKeyCert, rootCert, middleCert, ifValidateCNName);
                if (cert == null)
                {
                    return false;
                }

                result = SHA256WithRSA.VerifyData(stringSignDigest, signValue, cert.GetPublicKey());
            }
            else if ("11".Equals(signMethod) || "12".Equals(signMethod))
            {
                return ValidateBySecureKey(data, secureKey);
            }
            else
            {
                return false;
            }

            return result;
        }

        public static void SignByCertInfo(Dictionary<string, string> data, string certId, AsymmetricKeyParameter parameters)
        {
            if (!data.ContainsKey("signMethod"))
            {
                throw new Exception("signMethod must Not null");
            }

            if (!data.ContainsKey("version"))
            {
                throw new Exception("version must Not null");
            }

            var signMethod = data["signMethod"];
            if ("01".Equals(signMethod))
            {
                data["certId"] = certId;

                var stringData = GetSignContent(data, true, false);
                var stringSignDigest = SHA256.Compute(stringData);
                var stringSign = SHA256WithRSA.SignData(stringSignDigest, parameters);

                //设置签名域值
                data["signature"] = stringSign;
            }
            else
            {
                throw new Exception("Error signMethod [" + signMethod + "] in SignByCertInfo. ");
            }
        }

        public static void SignBySecureKey(Dictionary<string, string> data, string secureKey)
        {
            if (!data.ContainsKey("signMethod"))
            {
                throw new Exception("signMethod must Not null");
            }

            var stringData = GetSignContent(data, true, false);
            var signMethod = data["signMethod"];

            if ("11".Equals(signMethod))
            {
                var strBeforeSha256 = stringData + "&" + SHA256.Compute(secureKey);
                var strAfterSha256 = SHA256.Compute(strBeforeSha256);
                //设置签名域值
                data["signature"] = strAfterSha256;
            }
            else if ("12".Equals(signMethod))
            {
                var strBeforeSm3 = stringData + "&" + SM3.Compute(secureKey);
                var strAfterSm3 = SM3.Compute(strBeforeSm3);
                //设置签名域值
                data["signature"] = strAfterSm3;
            }
            else
            {
                throw new Exception("Error signMethod [" + signMethod + "] in SignBySecureKey. ");
            }
        }

        public static string GetSignContent(Dictionary<string, string> data, bool sort, bool encode)
        {
            if (data == null || data.Count == 0)
            {
                return string.Empty;
            }

            var list = new List<string>(data.Keys);

            if (sort)
            {
                list.Sort(StringComparer.Ordinal);
            }

            var sb = new StringBuilder();
            foreach (var key in list)
            {
                var value = encode ? WebUtility.UrlEncode(data[key]) : data[key];
                sb.Append(key).Append("=").Append(value).Append("&");
            }

            return sb.Remove(sb.Length - 1, 1).ToString();
        }

        public static UnionPayCertificate GetSignCertificate(string certificate, string certPwd)
        {
            var stream = File.Exists(certificate) ? File.OpenRead(certificate) : (Stream)new MemoryStream(Convert.FromBase64String(certificate));
            var store = new Pkcs12Store(stream, certPwd.ToCharArray());

            var alias = string.Empty;
            foreach (string n in store.Aliases)
            {
                if (store.IsKeyEntry(n))
                {
                    alias = n;
                }
            }

            var chain = store.GetCertificateChain(alias);
            var cert = chain[0].Certificate;

            return new UnionPayCertificate
            {
                key = store.GetKey(alias).Key,
                cert = cert,
                certId = cert.SerialNumber.ToString()
            };
        }

        public static UnionPayCertificate GetCertificate(string certificate)
        {
            var stream = File.Exists(certificate) ? File.OpenRead(certificate) : (Stream)new MemoryStream(Convert.FromBase64String(certificate));
            var cert = new X509CertificateParser().ReadCertificate(stream);

            return new UnionPayCertificate
            {
                key = cert.GetPublicKey(),
                cert = cert,
                certId = cert.SerialNumber.ToString()
            };
        }

        public static X509Certificate VerifyAndGetPubKey(string signPubKeyCert, X509Certificate rootCert, X509Certificate middleCert, bool ifValidateCNName)
        {
            if (!validateCerts.ContainsKey(signPubKeyCert))
            {
                var cert = GetPubKeyCert(signPubKeyCert);
                if (cert == null)
                {
                    return null;
                }

                if (VerifyCertificate(cert, rootCert, middleCert, ifValidateCNName))
                {
                    validateCerts.Add(signPubKeyCert, cert);
                }
                else
                {
                    return null;
                }
            }

            return validateCerts[signPubKeyCert];
        }

        public static X509Certificate GetPubKeyCert(string pubKeyCert)
        {
            try
            {
                pubKeyCert = pubKeyCert.Replace("-----END CERTIFICATE-----", string.Empty).Replace("-----BEGIN CERTIFICATE-----", string.Empty);
                var certBytes = Convert.FromBase64String(pubKeyCert);
                var cf = new X509CertificateParser();
                var cert = cf.ReadCertificate(certBytes);

                return cert;
            }
            catch
            {
                return null;
            }
        }

        private static bool VerifyCertificateChain(X509Certificate cert, X509Certificate rootCert, X509Certificate middleCert)
        {
            if (null == cert)
            {
                return false;
            }

            if (null == rootCert)
            {
                return false;
            }

            if (null == middleCert)
            {
                return false;
            }

            try
            {
                var selector = new X509CertStoreSelector
                {
                    Subject = cert.SubjectDN
                };

                var trustAnchors = new HashSet
                {
                    new TrustAnchor(rootCert, null)
                };

                var pkixParams = new PkixBuilderParameters(trustAnchors, selector);

                var intermediateCerts = new ArrayList
                {
                    rootCert,
                    middleCert,
                    cert
                };

                pkixParams.IsRevocationEnabled = false;

                var intermediateCertStore = X509StoreFactory.Create("Certificate/Collection", new X509CollectionStoreParameters(intermediateCerts));
                pkixParams.AddStore(intermediateCertStore);

                var pathBuilder = new PkixCertPathBuilder();
                var result = pathBuilder.Build(pkixParams);
                var path = result.CertPath;

                return true;
            }
            catch { }

            return false;
        }

        private static bool VerifyCertificate(X509Certificate cert, X509Certificate rootCert, X509Certificate middleCert, bool ifValidateCNName)
        {
            var cn = GetIdentitiesFromCertficate(cert);

            try
            {
                cert.CheckValidity();//验证有效期
                if (!VerifyCertificateChain(cert, rootCert, middleCert))  //验证书链
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

            if (ifValidateCNName)
            {
                // 验证公钥是否属于银联
                if (!UNIONPAY_CNNAME.Equals(cn))
                {
                    return false;
                }
            }
            else
            {
                if (!UNIONPAY_CNNAME.Equals(cn) && !"00040000:SIGN".Equals(cn))
                {
                    return false;
                }
            }

            return true;
        }

        private static string GetIdentitiesFromCertficate(X509Certificate cert)
        {
            var dn = cert.SubjectDN.ToString();
            var part = string.Empty;

            if (!string.IsNullOrEmpty(dn))
            {
                var splitStr = dn.Substring(dn.IndexOf("CN=")).Split("@".ToCharArray());
                if (splitStr != null && splitStr.Length > 2 && splitStr[2] != null)
                {
                    part = splitStr[2];
                }
            }

            return part;
        }

        public static bool ValidateBySecureKey(Dictionary<string, string> rspData, string secureKey)
        {
            if (!rspData.ContainsKey("signMethod") || !rspData.ContainsKey("signature"))
            {
                return false;
            }

            var result = false;
            var signMethod = rspData["signMethod"];

            if ("11".Equals(signMethod))
            {
                var stringSign = rspData["signature"];
                rspData.Remove("signature");
                var stringData = GetSignContent(rspData, true, false);
                var strBeforeSha256 = stringData + "&" + SHA256.Compute(secureKey);
                var strAfterSha256 = SHA256.Compute(strBeforeSha256);
                result = stringSign.Equals(strAfterSha256);
            }
            else if ("12".Equals(signMethod))
            {
                var stringSign = rspData["signature"];
                rspData.Remove("signature");
                var stringData = GetSignContent(rspData, true, false);
                var strBeforeSm3 = stringData + "&" + SM3.Compute(secureKey);
                var strAfterSm3 = SM3.Compute(strBeforeSm3);
                result = stringSign.Equals(strAfterSm3);
            }

            return result;
        }

        private static byte[] Pin2PinBlock(string pin)
        {
            var temp = 1;
            var pinLen = pin.Length;
            var bytes = new byte[8];

            try
            {
                bytes[0] = (byte)Convert.ToInt32(pinLen.ToString(), 10);
                if (pinLen % 2 == 0)
                {
                    for (var i = 0; i < pinLen;)
                    {
                        var a = pin.Substring(i, 2).Trim();
                        bytes[temp] = (byte)Convert.ToInt32(a, 16);
                        if (i == pinLen - 2)
                        {
                            if (temp < 7)
                            {
                                for (var x = temp + 1; x < 8; x++)
                                {
                                    bytes[x] = 0xff;
                                }
                            }
                        }
                        temp++;
                        i = i + 2;
                    }
                }
                else
                {
                    for (var i = 0; i < pinLen - 1;)
                    {
                        var a = pin.Substring(i, 2);
                        bytes[temp] = (byte)Convert.ToInt32(a, 16);
                        if (i == pinLen - 3)
                        {
                            var b = pin.Substring(pinLen - 1) + "F";
                            bytes[temp + 1] = (byte)Convert.ToInt32(b, 16);
                            if (temp + 1 < 7)
                            {
                                for (var x = temp + 2; x < 8; x++)
                                {
                                    bytes[x] = 0xff;
                                }
                            }
                        }
                        temp++;
                        i = i + 2;
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("Pin2PinBlock error" + e.Message);
            }

            return bytes;
        }

        private static byte[] FormatPan(string pan)
        {
            var panLen = pan.Length;
            var bytes = new byte[8];
            var temp = panLen - 13;

            try
            {
                bytes[0] = 0x00;
                bytes[1] = 0x00;
                for (var i = 2; i < 8; i++)
                {
                    var a = pan.Substring(temp, 2).Trim();
                    bytes[i] = (byte)Convert.ToInt32(a, 16);
                    temp = temp + 2;
                }
            }
            catch (Exception e)
            {
                throw new Exception("FormatPan error:" + e.Message);
            }

            return bytes;
        }

        public static byte[] Pin2PinBlockWithCardNO(string pin, string cardNO)
        {
            var pinBlockBytes = Pin2PinBlock(pin);

            if (cardNO.Length == 11)
            {
                cardNO = "00" + cardNO;
            }
            else if (cardNO.Length == 12)
            {
                cardNO = "0" + cardNO;
            }

            var cardNoPanBytes = FormatPan(cardNO);
            var bytes = new byte[8];

            for (var i = 0; i < 8; i++)
            {
                bytes[i] = (byte)(pinBlockBytes[i] ^ cardNoPanBytes[i]);
            }

            return bytes;
        }

        public static string EncryptPin(string pin, string card, AsymmetricKeyParameter key)
        {
            var pinBlock = Pin2PinBlockWithCardNO(pin, card);
            return Convert.ToBase64String(RSA_NONE_PKCS1Padding.Encrypt(pinBlock, key));
        }

        public static string DecryptData(string dataString, string cert, string certPwd)
        {
            var certificate = GetSignCertificate(cert, certPwd);
            return RSA_NONE_PKCS1Padding.Decrypt(dataString, certificate.key);
        }
    }
}
