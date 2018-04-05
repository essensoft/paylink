using Essensoft.AspNetCore.Security;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Pkix;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Essensoft.AspNetCore.Payment.UnionPay.Utility
{
    public class UnionPaySignature
    {
        private static readonly string UNIONPAY_CNNAME = "中国银联股份有限公司";

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

        public static bool Validate(Dictionary<string, string> rspData, X509Certificate rootCert, X509Certificate middleCert, string secureKey, bool ifValidateCNName)
        {
            if (!rspData.ContainsKey("signMethod") || !rspData.ContainsKey("signature") || !rspData.ContainsKey("version"))
            {
                return false;
            }

            var signMethod = rspData["signMethod"];
            var version = rspData["version"];
            var result = false;

            if ("01".Equals(signMethod))
            {
                var signValue = rspData["signature"];
                var signByte = Convert.FromBase64String(signValue);
                rspData.Remove("signature");
                var stringData = GetSignContent(rspData, true, false);
                var stringSignDigest = SHA256.Compute(stringData);

                var signPubKeyCert = rspData["signPubKeyCert"];
                var cert = VerifyAndGetPubKey(signPubKeyCert, rootCert, middleCert, ifValidateCNName);
                if (cert == null)
                {
                    return false;
                }
                result = ValidateSha256WithRsa(cert.GetPublicKey(), signByte, Encoding.UTF8.GetBytes(stringSignDigest));
            }
            else if ("11".Equals(signMethod) || "12".Equals(signMethod))
            {
                return ValidateBySecureKey(rspData, secureKey);
            }
            else
            {
                return false;
            }
            return result;
        }

        public static void SignByCertInfo(Dictionary<string, string> reqData, string certId, AsymmetricKeyParameter parameters)
        {
            if (!reqData.ContainsKey("signMethod"))
            {
                throw new Exception("signMethod must Not null");
            }
            var signMethod = reqData["signMethod"];

            if (!reqData.ContainsKey("version"))
            {
                throw new Exception("version must Not null");
            }
            var version = reqData["version"];

            if ("01".Equals(signMethod))
            {
                reqData["certId"] = certId;

                var stringData = GetSignContent(reqData, true, false);
                var stringSignDigest = SHA256.Compute(stringData);

                var stringSign = SignSha256WithRsa(stringSignDigest, parameters);

                //设置签名域值
                reqData["signature"] = stringSign;
            }
            else
            {
                throw new Exception("Error signMethod [" + signMethod + "] in SignByCertInfo. ");
            }
        }

        public static void SignBySecureKey(Dictionary<string, string> reqData, string secureKey)
        {
            if (!reqData.ContainsKey("signMethod"))
            {
                throw new Exception("signMethod must Not null");
            }
            var signMethod = reqData["signMethod"];

            var stringData = GetSignContent(reqData, true, false);

            if ("11".Equals(signMethod))
            {
                var strBeforeSha256 = stringData + "&" + SHA256.Compute(secureKey);
                var strAfterSha256 = SHA256.Compute(strBeforeSha256);
                //设置签名域值
                reqData["signature"] = strAfterSha256;
            }
            else if ("12".Equals(signMethod))
            {
                var strBeforeSm3 = stringData + "&" + SM3.Compute(secureKey);
                var strAfterSm3 = SM3.Compute(strBeforeSm3);
                //设置签名域值
                reqData["signature"] = strAfterSm3;
            }
            else
            {
                throw new Exception("Error signMethod [" + signMethod + "] in SignBySecureKey. ");
            }
        }

        public static string GetSignContent(Dictionary<string, string> para, bool sort, bool encode)
        {
            if (para == null || para.Count == 0)
                return string.Empty;

            var list = new List<string>(para.Keys);

            if (sort)
                list.Sort(StringComparer.Ordinal);

            var sb = new StringBuilder();
            foreach (var key in list)
            {
                var value = encode ? WebUtility.UrlEncode(para[key]) : para[key];
                sb.Append(key).Append("=").Append(value).Append("&");
            }

            return sb.Remove(sb.Length - 1, 1).ToString();
        }

        public static string SignSha256WithRsa(string data, AsymmetricKeyParameter key)
        {
            var normalSig = SignerUtilities.GetSigner("SHA256WithRSA");
            normalSig.Init(true, key);
            normalSig.BlockUpdate(Encoding.UTF8.GetBytes(data), 0, data.Length);
            return Convert.ToBase64String(normalSig.GenerateSignature());
        }

        public static string SignSha1WithRsa(string data, AsymmetricKeyParameter key)
        {
            var normalSig = SignerUtilities.GetSigner("SHA1WithRSA");
            normalSig.Init(true, key);
            normalSig.BlockUpdate(Encoding.UTF8.GetBytes(data), 0, data.Length);
            return Convert.ToBase64String(normalSig.GenerateSignature());

        }

        public static bool ValidateSha1WithRsa(AsymmetricKeyParameter key, byte[] base64DecodingSignStr, byte[] srcByte)
        {
            var verifier = SignerUtilities.GetSigner("SHA1WithRSA");
            verifier.Init(false, key);
            verifier.BlockUpdate(srcByte, 0, srcByte.Length);
            return verifier.VerifySignature(base64DecodingSignStr);
        }

        public static bool ValidateSha256WithRsa(AsymmetricKeyParameter key, byte[] base64DecodingSignStr, byte[] srcByte)
        {
            var verifier = SignerUtilities.GetSigner("SHA256WithRSA");
            verifier.Init(false, key);
            verifier.BlockUpdate(srcByte, 0, srcByte.Length);
            return verifier.VerifySignature(base64DecodingSignStr);
        }

        public static UnionPayCertificate GetSignCertificate(string certificate, string certPwd)
        {
            var stream = new MemoryStream(Convert.FromBase64String(certificate));
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
            var stream = new MemoryStream(Convert.FromBase64String(certificate));
            var x509certificate = new X509CertificateParser().ReadCertificate(stream);

            return new UnionPayCertificate
            {
                key = x509certificate.GetPublicKey(),
                cert = x509certificate,
                certId = x509certificate.SerialNumber.ToString()
            };
        }

        private static Dictionary<string, X509Certificate> validateCerts = new Dictionary<string, X509Certificate>();

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
                var x509CertBytes = Convert.FromBase64String(pubKeyCert);
                var cf = new X509CertificateParser();
                var x509Cert = cf.ReadCertificate(x509CertBytes);
                return x509Cert;
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

                var intermediateCertStore = X509StoreFactory.Create(
                    "Certificate/Collection",
                    new X509CollectionStoreParameters(intermediateCerts));
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

        private static string GetIdentitiesFromCertficate(X509Certificate aCert)
        {
            var tDN = aCert.SubjectDN.ToString();
            var tPart = "";
            if ((tDN != null))
            {
                var tSplitStr = tDN.Substring(tDN.IndexOf("CN=")).Split("@".ToCharArray());
                if (tSplitStr != null && tSplitStr.Length > 2
                        && tSplitStr[2] != null)
                    tPart = tSplitStr[2];
            }
            return tPart;
        }

        public static bool ValidateBySecureKey(Dictionary<string, string> rspData, string secureKey)
        {
            if (!rspData.ContainsKey("signMethod") || !rspData.ContainsKey("signature"))
            {
                return false;
            }
            var signMethod = rspData["signMethod"];

            var result = false;
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
            else
            {
                return false;
            }

            return result;
        }

        private static byte[] Pin2PinBlock(string aPin)
        {
            var tTemp = 1;
            var tPinLen = aPin.Length;

            var tByte = new byte[8];
            try
            {
                tByte[0] = (byte)Convert.ToInt32(tPinLen.ToString(), 10);
                if (tPinLen % 2 == 0)
                {
                    for (var i = 0; i < tPinLen;)
                    {
                        var a = aPin.Substring(i, 2).Trim();
                        tByte[tTemp] = (byte)Convert.ToInt32(a, 16);
                        if (i == (tPinLen - 2))
                        {
                            if (tTemp < 7)
                            {
                                for (var x = (tTemp + 1); x < 8; x++)
                                {
                                    tByte[x] = 0xff;
                                }
                            }
                        }
                        tTemp++;
                        i = i + 2;
                    }
                }
                else
                {
                    for (var i = 0; i < tPinLen - 1;)
                    {
                        string a;
                        a = aPin.Substring(i, 2);
                        tByte[tTemp] = (byte)Convert.ToInt32(a, 16);
                        if (i == (tPinLen - 3))
                        {
                            var b = aPin.Substring(tPinLen - 1) + "F";
                            tByte[tTemp + 1] = (byte)Convert.ToInt32(b, 16);
                            if ((tTemp + 1) < 7)
                            {
                                for (var x = (tTemp + 2); x < 8; x++)
                                {
                                    tByte[x] = 0xff;
                                }
                            }
                        }
                        tTemp++;
                        i = i + 2;
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("Pin2PinBlock error" + e.Message);
            }

            return tByte;
        }

        private static byte[] FormatPan(string aPan)
        {
            var tPanLen = aPan.Length;
            var tByte = new byte[8];
            var temp = tPanLen - 13;
            try
            {
                tByte[0] = 0x00;
                tByte[1] = 0x00;
                for (var i = 2; i < 8; i++)
                {
                    var a = aPan.Substring(temp, 2).Trim();
                    tByte[i] = (byte)Convert.ToInt32(a, 16);
                    temp = temp + 2;
                }
            }
            catch (Exception e)
            {
                throw new Exception("FormatPan error:" + e.Message);
            }
            return tByte;
        }

        public static byte[] Pin2PinBlockWithCardNO(string aPin, string aCardNO)
        {
            var tPinByte = Pin2PinBlock(aPin);
            if (aCardNO.Length == 11)
            {
                aCardNO = "00" + aCardNO;
            }
            else if (aCardNO.Length == 12)
            {
                aCardNO = "0" + aCardNO;
            }
            var tPanByte = FormatPan(aCardNO);


            var tByte = new byte[8];
            for (var i = 0; i < 8; i++)
            {
                tByte[i] = (byte)(tPinByte[i] ^ tPanByte[i]);
            }
            return tByte;

        }

        public static byte[] EncryptData(byte[] data, AsymmetricKeyParameter key)
        {
            try
            {
                var c = CipherUtilities.GetCipher("RSA/NONE/PKCS1Padding");
                c.Init(true, new ParametersWithRandom(key, new SecureRandom()));
                return c.DoFinal(data);
            }
            catch (Exception e)
            {
                throw new Exception("EncryptedData error: " + e.Message);
            }
        }

        public static string EncryptData(string dataString, AsymmetricKeyParameter key)
        {
            var data = EncryptData(Encoding.UTF8.GetBytes(dataString), key);
            return Convert.ToBase64String(data);
        }

        public static string EncryptPin(string pin, string card, AsymmetricKeyParameter key)
        {
            var pinBlock = Pin2PinBlockWithCardNO(pin, card);
            var data = EncryptData(pinBlock, key);
            return Convert.ToBase64String(data);
        }

        public static byte[] DecryptData(byte[] data, AsymmetricKeyParameter key)
        {
            try
            {
                var c = CipherUtilities.GetCipher("RSA/NONE/PKCS1Padding");
                c.Init(false, key);
                return c.DoFinal(data);
            }
            catch (Exception e)
            {
                throw new Exception("Decrypt data error: " + e.Message);
            }
        }

        public static string DecryptData(string dataString, AsymmetricKeyParameter key)
        {
            var data = Convert.FromBase64String(dataString);
            var decryptData = DecryptData(data, key);
            return Encoding.UTF8.GetString(data);
        }

        public static string DecryptData(string dataString, string cert, string certPwd)
        {
            var data = Convert.FromBase64String(dataString);
            var certificate = GetSignCertificate(cert, certPwd);
            data = DecryptData(data, certificate.key);
            return Encoding.UTF8.GetString(data);
        }
    }
}
