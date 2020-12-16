using System;
using System.Collections;
using System.Security.Cryptography;
using System.Text.Json;
using Essensoft.AspNetCore.Payment.Alipay.Utility;
using Essensoft.AspNetCore.Payment.Security;

namespace Essensoft.AspNetCore.Payment.Alipay.Parser
{
    /// <summary>
    /// Alipay JSON响应通用解释器。
    /// </summary>
    public class AlipayJsonParser<T> : IAlipayParser<T> where T : AlipayResponse
    {
        #region IAlipayParser<T> Members

        public T Parse(string body)
        {
            if (string.IsNullOrEmpty(body))
            {
                throw new ArgumentNullException(nameof(body));
            }

            T rsp = null;
            IDictionary json = null;

            try
            {
                if (body.StartsWith("{") && body.EndsWith("}"))
                {
                    json = JsonSerializer.Deserialize<IDictionary>(body, JsonParser.JsonSerializerOptions);
                }

                if (json != null)
                {
                    // 忽略根节点的名称
                    foreach (var key in json.Keys)
                    {
                        rsp = JsonSerializer.Deserialize<T>(json[key].ToString(), JsonParser.JsonSerializerOptions);
                        if (rsp != null)
                        {
                            break;
                        }
                    }
                }
            }
            catch { }

            if (rsp == null)
            {
                rsp = Activator.CreateInstance<T>();
            }

            if (rsp != null)
            {
                rsp.Body = body;
            }

            return rsp;
        }

        public SignItem GetSignItem(IAlipayRequest<T> request, string body)
        {
            if (string.IsNullOrEmpty(body))
            {
                return null;
            }

            var signItem = new SignItem
            {
                Sign = GetSign(body),
                SignSourceData = GetSignSourceData(request, body)
            };

            return signItem;
        }

        public CertItem GetCertItem(IAlipayRequest<T> request, string body)
        {
            if (string.IsNullOrEmpty(body))
            {
                return null;
            }

            var json = JsonSerializer.Deserialize<IDictionary>(body, JsonParser.JsonSerializerOptions);
            var certItem = new CertItem()
            {
                Sign = json[AlipayConstants.SIGN]?.ToString(),
                CertSN = json[AlipayConstants.ALIPAY_CERT_SN]?.ToString(),
                SignSourceData = GetSignSourceData(request, body)
            };

            return certItem;
        }

        #endregion

        private static string GetSign(string body)
        {
            var json = JsonSerializer.Deserialize<IDictionary>(body, JsonParser.JsonSerializerOptions);
            return json[AlipayConstants.SIGN]?.ToString();
        }

        private static string GetSignSourceData(IAlipayRequest<T> request, string body)
        {
            var rootNode = request.GetApiName().Replace(".", "_") + AlipayConstants.RESPONSE_SUFFIX;
            var errorRootNode = AlipayConstants.ERROR_RESPONSE;

            var indexOfRootNode = body.IndexOf(rootNode, StringComparison.Ordinal);
            var indexOfErrorRoot = body.IndexOf(errorRootNode, StringComparison.Ordinal);

            string result = null;
            if (indexOfRootNode > 0)
            {
                result = ParseSignSourceData(body, rootNode, indexOfRootNode);
            }
            else if (indexOfErrorRoot > 0)
            {
                result = ParseSignSourceData(body, errorRootNode, indexOfErrorRoot);
            }

            return result;
        }

        private static string ParseSignSourceData(string body, string rootNode, int indexOfRootNode)
        {
            var signDataStartIndex = indexOfRootNode + rootNode.Length + 2;
            var indexOfSign = body.IndexOf($"\"{AlipayConstants.SIGN}\"", StringComparison.Ordinal);
            if (indexOfSign < 0)
            {
                return null;
            }

            var signSourceData = AlipaySignature.ExtractSignContent(body, signDataStartIndex);

            //如果提取的待验签原始内容后还有rootNode
            if (body.LastIndexOf(rootNode, StringComparison.Ordinal) > signSourceData.EndIndex)
            {
                throw new AlipayException("检测到响应报文中有重复的" + rootNode + "，验签失败。");
            }

            return signSourceData.SourceData;
        }

        public string EncryptSourceData(IAlipayRequest<T> request, string body, string encryptType, string encryptKey)
        {
            if (!"AES".Equals(encryptType))
            {
                throw new AlipayException("API only support AES!");
            }

            var item = ParseEncryptData(request, body);
            var bodyIndexContent = body.Substring(0, item.startIndex);
            var bodyEndexContent = body[item.endIndex..];
            var bizContent = AES.Decrypt(item.encryptContent, encryptKey, AlipaySignature.AES_IV, CipherMode.CBC, PaddingMode.PKCS7);

            return bodyIndexContent + bizContent + bodyEndexContent;
        }

        /// <summary>
        /// 解析加密节点
        /// </summary>
        /// <param name="request"></param>
        /// <param name="body"></param>
        private static EncryptParseItem ParseEncryptData(IAlipayRequest<T> request, string body)
        {
            var rootNode = request.GetApiName().Replace(".", "_") + AlipayConstants.RESPONSE_SUFFIX;
            var errorRootNode = AlipayConstants.ERROR_RESPONSE;

            var indexOfRootNode = body.IndexOf(rootNode, StringComparison.Ordinal);
            var indexOfErrorRoot = body.IndexOf(errorRootNode, StringComparison.Ordinal);

            EncryptParseItem result = null;
            if (indexOfRootNode > 0)
            {
                result = ParseEncryptItem(body, rootNode, indexOfRootNode);
            }
            else if (indexOfErrorRoot > 0)
            {
                result = ParseEncryptItem(body, errorRootNode, indexOfErrorRoot);
            }

            return result;
        }

        private static EncryptParseItem ParseEncryptItem(string body, string rootNode, int indexOfRootNode)
        {
            var signDataStartIndex = indexOfRootNode + rootNode.Length + 2;
            var indexOfSign = body.IndexOf($"\"{AlipayConstants.SIGN}\"", StringComparison.Ordinal);

            var signDataEndIndex = indexOfSign - 1;

            if (signDataEndIndex < 0)
            {
                signDataEndIndex = body.Length - 1;
            }

            var length = signDataEndIndex - signDataStartIndex;

            var encyptContent = body.Substring(signDataStartIndex + 1, length - 2);

            var item = new EncryptParseItem
            {
                encryptContent = encyptContent,
                startIndex = signDataStartIndex,
                endIndex = signDataEndIndex
            };
            return item;
        }
    }
}
