using Essensoft.AspNetCore.Payment.WeChatPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    public class WeChatPayGetPublicKeyRequest : IWeChatPayCertificateRequest<WeChatPayGetPublicKeyResponse>
    {
        #region IWeChatPayRequest Members

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
