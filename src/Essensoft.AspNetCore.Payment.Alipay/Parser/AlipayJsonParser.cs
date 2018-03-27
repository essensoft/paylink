using Essensoft.AspNetCore.Payment.Alipay.Request;
using Essensoft.AspNetCore.Payment.Alipay.Utility;
using Newtonsoft.Json;
using System;
using System.Collections;

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
            T rsp = null;
            try
            {
                var json = JsonConvert.DeserializeObject<IDictionary>(body);
                if (json != null)
                {
                    // 忽略根节点的名称
                    foreach (var key in json.Keys)
                    {
                        var data = json[key].ToString();
                        if (!string.IsNullOrEmpty(data))
                        {
                            rsp = JsonConvert.DeserializeObject<T>(data);
                            break;
                        }
                    }
                }
            }
            catch { }

            if (rsp == null)
                rsp = Activator.CreateInstance<T>();

            if (rsp != null)
                rsp.Body = body;

            return rsp;
        }

        public SignItem GetSignItem(IAlipayRequest<T> request, string responseBody)
        {
            if (string.IsNullOrEmpty(responseBody))
            {
                return null;
            }

            var signItem = new SignItem()
            {
                Sign = GetSign(responseBody),
                SignSourceDate = GetSignSourceData(request, responseBody)
            };
            return signItem;
        }

        #endregion

        private static string GetSign(string body)
        {
            var json = JsonConvert.DeserializeObject<IDictionary>(body);
            return (string)json[AlipayConstants.SIGN];
        }

        private static string GetSignSourceData(IAlipayRequest<T> request, string body)
        {
            var rootNode = AlipayUtility.GetRootElement(request.GetApiName());
            var errorRootNode = AlipayConstants.ERROR_RESPONSE;

            var indexOfRootNode = body.IndexOf(rootNode);
            var indexOfErrorRoot = body.IndexOf(errorRootNode);

            string result = null;
            if (indexOfRootNode > 0)
                result = ParseSignSourceData(body, rootNode, indexOfRootNode);
            else if (indexOfErrorRoot > 0)
                result = ParseSignSourceData(body, errorRootNode, indexOfErrorRoot);

            return result;
        }

        private static string ParseSignSourceData(string body, string rootNode, int indexOfRootNode)
        {
            var signDataStartIndex = indexOfRootNode + rootNode.Length + 2;
            var indexOfSign = body.IndexOf("\"" + AlipayConstants.SIGN + "\"");
            if (indexOfSign < 0)
            {
                return null;
            }

            var signDataEndIndex = indexOfSign - 1;
            var length = signDataEndIndex - signDataStartIndex;

            return body.Substring(signDataStartIndex, length);
        }

        public string EncryptSourceData(IAlipayRequest<T> request, string body, string encryptType, string encryptKey)
        {

            if (!"AES".Equals(encryptType))
            {
                throw new AlipayException("API only support AES!");
            }

            var item = ParseEncryptData(request, body);

            var bodyIndexContent = body.Substring(0, item.startIndex);
            var bodyEndexContent = body.Substring(item.endIndex);

            //TODO 解密逻辑
            var bizContent = AlipayEncrypt.AesDencrypt(encryptKey, item.encryptContent);

            return bodyIndexContent + bizContent + bodyEndexContent;
        }

        /// <summary>
        /// 解析加密节点
        /// </summary>
        /// <param name="request"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        private static EncryptParseItem ParseEncryptData(IAlipayRequest<T> request, string body)
        {
            var rootNode = request.GetApiName().Replace(".", "_") + AlipayConstants.RESPONSE_SUFFIX;
            var errorRootNode = AlipayConstants.ERROR_RESPONSE;

            var indexOfRootNode = body.IndexOf(rootNode);
            var indexOfErrorRoot = body.IndexOf(errorRootNode);

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
            var indexOfSign = body.IndexOf("\"" + AlipayConstants.SIGN + "\"");

            var signDataEndIndex = indexOfSign - 1;

            if (signDataEndIndex < 0)
            {
                signDataEndIndex = body.Length - 1;
            }

            var length = signDataEndIndex - signDataStartIndex;

            var encyptContent = body.Substring(signDataStartIndex + 1, length - 2);

            var item = new EncryptParseItem()
            {
                encryptContent = encyptContent,
                startIndex = signDataStartIndex,
                endIndex = signDataEndIndex
            };
            return item;
        }
    }
}
