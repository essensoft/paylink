using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// 获取RSA加密公钥
    /// </summary>
    public class WeChatPayGetPublicKeyRequest : IWeChatPayCertificateRequest<WeChatPayGetPublicKeyResponse>
    {
        #region IWeChatPayCertificateRequest Members

        public string GetRequestUrl()
        {
            return "https://fraud.mch.weixin.qq.com/risk/getpublickey";
        }

        public IDictionary<string, string> GetParameters()
        {
            return new WeChatPayDictionary();
        }

        #endregion
    }
}
