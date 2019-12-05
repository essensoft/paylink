using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.X509;
using MD5 = Essensoft.AspNetCore.Payment.Security.MD5;

namespace Essensoft.AspNetCore.Payment.Alipay.Utility
{
    /// <summary>
    /// 证书相关工具类
    /// </summary>
    public static class AntCertificationUtil
    {
        /// <summary>
        /// 提取根证书序列号
        /// </summary>
        /// <param name="rootCertContent">根证书文本</param>
        /// <returns>根证书序列号</returns>
        public static string GetRootCertSN(string rootCertContent)
        {
            var rootCertSN = "";
            try
            {
                var x509Certificates = ReadPemCertChain(rootCertContent);
                foreach (var cert in x509Certificates)
                {
                    if (cert.SigAlgOid.StartsWith("1.2.840.113549.1.1", StringComparison.Ordinal))
                    {
                        var certSN = GetCertSN(cert);
                        if (string.IsNullOrEmpty(rootCertSN))
                        {
                            rootCertSN = certSN;
                        }
                        else
                        {
                            rootCertSN = rootCertSN + "_" + certSN;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new AlipayException("提取根证书序列号失败。" + ex.Message);
            }

            return rootCertSN;
        }

        /// <summary>
        /// 反序列化证书
        /// </summary>
        /// <param name="certificate">证书</param>
        /// <returns>X509Certificate证书对象</returns>
        public static X509Certificate ParseCert(string certificate)
        {
            var certContent = File.Exists(certificate) ? File.ReadAllText(certificate) : certificate;
            return new X509CertificateParser().ReadCertificate(Encoding.UTF8.GetBytes(certContent));
        }

        /// <summary>
        /// 计算指定证书的序列号
        /// </summary>
        /// <param name="cert">证书</param>
        /// <returns>序列号</returns>
        public static string GetCertSN(X509Certificate cert)
        {
            var issuerDN = cert.IssuerDN.ToString();
            //提取出的证书的issuerDN本身是以CN开头的，则无需逆序，直接返回
            if (issuerDN.StartsWith("CN", StringComparison.Ordinal))
            {
                return MD5.Compute(issuerDN + cert.SerialNumber).ToLower();
            }
            else
            {
                var attributes = issuerDN.Split(',').ToList();
                attributes.Reverse();

                return MD5.Compute(string.Join(",", attributes.ToArray()) + cert.SerialNumber).ToLower();
            }
        }

        /// <summary>
        /// 校验证书链是否可信
        /// </summary>
        /// <param name="certContent">需要验证的目标证书或者证书链文本</param>
        /// <param name="rootCertContent">可信根证书列表文本</param>
        /// <returns>true：证书可信；false：证书不可信</returns>
        public static bool IsTrusted(string certContent, string rootCertContent)
        {
            var certs = ReadPemCertChain(certContent);
            var rootCerts = ReadPemCertChain(rootCertContent);

            return VerifyCertChain(certs, rootCerts);
        }

        /// <summary>
        /// 从证书链文本反序列化证书链集合
        /// </summary>
        /// <param name="cert">证书链文本</param>
        /// <returns>证书链集合</returns>
        private static List<X509Certificate> ReadPemCertChain(string cert)
        {
            var certContent = File.Exists(cert) ? File.ReadAllText(cert) : cert;
            var collection = new X509CertificateParser().ReadCertificates(Encoding.UTF8.GetBytes(certContent));
            var result = new List<X509Certificate>();
            foreach (var each in collection)
            {
                result.Add((X509Certificate)each);
            }

            return result;
        }

        /// <summary>
        /// 将证书链按照完整的签发顺序进行排序，排序后证书链为：[issuerA, subjectA]-[issuerA, subjectB]-[issuerB, subjectC]-[issuerC, subjectD]...
        /// </summary>
        /// <param name="certChain">未排序的证书链</param>
        /// <returns>true：排序成功；false：证书链不完整</returns>
        private static bool SortCertChain(List<X509Certificate> certChain)
        {
            //主题和证书的映射
            var subject2CertMap = new Dictionary<X509Name, X509Certificate>();
            //签发者和证书的映射
            var issuer2CertMap = new Dictionary<X509Name, X509Certificate>();
            //是否包含自签名证书
            var hasSelfSignedCert = false;
            foreach (var cert in certChain)
            {
                if (IsSelfSigned(cert))
                {
                    if (hasSelfSignedCert)
                    {
                        //同一条证书链中只能有一个自签名证书
                        return false;
                    }
                    hasSelfSignedCert = true;
                }
                subject2CertMap[cert.SubjectDN] = cert;
                issuer2CertMap[cert.IssuerDN] = cert;
            }

            var orderedCertChain = new List<X509Certificate>();

            var current = certChain[0];

            AddressingUp(subject2CertMap, orderedCertChain, current);
            AddressingDown(issuer2CertMap, orderedCertChain, current);

            //说明证书链不完整
            if (certChain.Count != orderedCertChain.Count)
            {
                return false;
            }

            //用排序后的结果覆盖传入的证书链集合
            for (var i = 0; i < orderedCertChain.Count; i++)
            {
                certChain[i] = orderedCertChain[i];
            }

            return true;
        }

        private static bool IsSelfSigned(X509Certificate cert)
        {
            return cert.SubjectDN.Equivalent(cert.IssuerDN);
        }

        /// <summary>
        /// 向上构造证书链
        /// </summary>
        /// <param name="subject2CertMap">主题与证书的映射</param>
        /// <param name="orderedCertChain">储存排序后的证书链集合</param>
        /// <param name="current">当前需要插入排序后的证书链集合中的证书</param>
        private static void AddressingUp(Dictionary<X509Name, X509Certificate> subject2CertMap, List<X509Certificate> orderedCertChain, X509Certificate current)
        {
            orderedCertChain.Insert(0, current);
            if (IsSelfSigned(current))
            {
                return;
            }

            if (!subject2CertMap.ContainsKey(current.IssuerDN))
            {
                return;
            }

            var issuer = subject2CertMap[current.IssuerDN];
            AddressingUp(subject2CertMap, orderedCertChain, issuer);
        }

        /// <summary>
        /// 向下构造证书链
        /// </summary>
        /// <param name="issuer2CertMap">签发者和证书的映射</param>
        /// <param name="certChain">储存排序后的证书链集合</param>
        /// <param name="current">当前需要插入排序后的证书链集合中的证书</param>
        private static void AddressingDown(Dictionary<X509Name, X509Certificate> issuer2CertMap, List<X509Certificate> certChain, X509Certificate current)
        {
            if (!issuer2CertMap.ContainsKey(current.SubjectDN))
            {
                return;
            }

            var subject = issuer2CertMap[current.SubjectDN];
            if (IsSelfSigned(subject))
            {
                return;
            }
            certChain.Add(subject);
            AddressingDown(issuer2CertMap, certChain, subject);
        }

        /// <summary>
        /// 验证证书是否是信任证书库中的证书签发的
        /// </summary>
        /// <param name="cert">待验证证书</param>
        /// <param name="rootCerts">可信根证书列表</param>
        /// <returns>true：验证通过；false：验证不通过</returns>
        private static bool VerifyCert(X509Certificate cert, List<X509Certificate> rootCerts)
        {
            if (!cert.IsValidNow)
            {
                return false;
            }

            var subject2CertMap = new Dictionary<X509Name, X509Certificate>();
            foreach (var root in rootCerts)
            {
                subject2CertMap[root.SubjectDN] = root;
            }

            var issuerDN = cert.IssuerDN;
            if (!subject2CertMap.ContainsKey(issuerDN))
            {
                return false;
            }

            var issuer = subject2CertMap[issuerDN];
            try
            {
                var publicKey = issuer.GetPublicKey();
                cert.Verify(publicKey);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// 验证证书列表
        /// </summary>
        /// <param name="certs">待验证的证书列表</param>
        /// <param name="rootCerts">可信根证书列表</param>
        /// <returns>true：验证通过；false：验证不通过</returns>
        private static bool VerifyCertChain(List<X509Certificate> certs, List<X509Certificate> rootCerts)
        {
            //证书列表排序，形成排序后的证书链
            var sorted = SortCertChain(certs);
            if (!sorted)
            {
                //不是完整的证书链
                return false;
            }

            //先验证第一个证书是不是信任库中证书签发的
            var previous = certs[0];
            var firstOK = VerifyCert(previous, rootCerts);
            if (!firstOK || certs.Count == 1)
            {
                return firstOK;
            }

            //验证证书链
            for (var i = 1; i < certs.Count; i++)
            {
                try
                {
                    var cert = certs[i];
                    if (!cert.IsValidNow)
                    {
                        return false;
                    }

                    //用上级证书的公钥验证本证书是否是上级证书签发的
                    cert.Verify(previous.GetPublicKey());

                    previous = cert;
                }
                catch (Exception)
                {
                    //证书链验证失败
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// 从证书中提取公钥并转换为PEM格式
        /// </summary>
        /// <param name="input">证书</param>
        /// <returns>PEM格式公钥</returns>
        public static string ExtractPemPublicKeyFromCert(X509Certificate input)
        {
            using (var cert = new System.Security.Cryptography.X509Certificates.X509Certificate2(input.GetEncoded()))
            {
                byte[] algOid;

                switch (cert.GetKeyAlgorithm())
                {
                    case "1.2.840.113549.1.1.1":
                        algOid = new byte[] { 0x06, 0x09, 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x01 };
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Need an OID lookup for " + cert.GetKeyAlgorithm());
                }

                var algParams = cert.GetKeyAlgorithmParameters();
                var publicKey = WrapAsBitString(cert.GetPublicKey());

                var algId = BuildSimpleDerSequence(algOid, algParams);
                var spki = BuildSimpleDerSequence(algId, publicKey);

                return Convert.ToBase64String(spki);
            }
        }

        private static byte[] BuildSimpleDerSequence(params byte[][] values)
        {
            var totalLength = values.Sum(v => v.Length);
            var len = EncodeDerLength(totalLength);
            var offset = 1;

            var seq = new byte[totalLength + len.Length + 1];
            seq[0] = 0x30;

            Buffer.BlockCopy(len, 0, seq, offset, len.Length);
            offset += len.Length;

            foreach (var value in values)
            {
                Buffer.BlockCopy(value, 0, seq, offset, value.Length);
                offset += value.Length;
            }

            return seq;
        }

        private static byte[] WrapAsBitString(byte[] value)
        {
            var len = EncodeDerLength(value.Length + 1);
            var bitString = new byte[value.Length + len.Length + 2];
            bitString[0] = 0x03;
            Buffer.BlockCopy(len, 0, bitString, 1, len.Length);
            bitString[len.Length + 1] = 0x00;
            Buffer.BlockCopy(value, 0, bitString, len.Length + 2, value.Length);
            return bitString;
        }

        private static byte[] EncodeDerLength(int length)
        {
            if (length <= 0x7F)
            {
                return new byte[] { (byte)length };
            }

            if (length <= 0xFF)
            {
                return new byte[] { 0x81, (byte)length };
            }

            if (length <= 0xFFFF)
            {
                return new byte[]
                {
                    0x82,
                    (byte)(length >> 8),
                    (byte)length,
                };
            }

            if (length <= 0xFFFFFF)
            {
                return new byte[]
                {
                    0x83,
                    (byte)(length >> 16),
                    (byte)(length >> 8),
                    (byte)length,
                };
            }

            return new byte[]
            {
                0x84,
                (byte)(length >> 24),
                (byte)(length >> 16),
                (byte)(length >> 8),
                (byte)length,
            };
        }
    }
}
