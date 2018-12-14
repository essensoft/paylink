using System;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.Response;
using Essensoft.AspNetCore.Payment.WeChatPay.Utility;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// 获取RSA加密公钥
    /// </summary>
    public class WeChatPayGetPublicKeyRequest : WeChatPayCertificateRequest<WeChatPayGetPublicKeyResponse>
    {
        #region IWeChatPayCertificateRequest Members

        public override string GetRequestUrl()
        {
            return "https://fraud.mch.weixin.qq.com/risk/getpublickey";
        }

        protected override IDictionary<string, string> GetParameters()
        {
            return new WeChatPayDictionary();
        }
        public override void CheckResponseSign(WeChatPayResponse response, WeChatPayOptions options)
        {
        }
        protected override void HandleParametersInOptions(WeChatPayDictionary sortedTxtParams, WeChatPayOptions options)
        {
            base.HandleParametersInOptions(sortedTxtParams, options);

            sortedTxtParams.Add(ConstKey.Key_mch_id, options.MchId);
            sortedTxtParams.Add(ConstKey.Key_sign_type, ConstKey.Key_MD5);
        }
        protected override void HandleSign(WeChatPayDictionary sortedTxtParams, WeChatPayOptions options)
        {
            sortedTxtParams.Add(ConstKey.Key_sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.Key, true, false));
        }

        #endregion
    }
}
