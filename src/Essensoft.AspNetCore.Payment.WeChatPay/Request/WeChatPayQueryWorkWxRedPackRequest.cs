using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// 企业红包 - 查询红包记录
    /// </summary>
    public class WeChatPayQueryWorkWxRedPackRequest : IWeChatPayCertificateRequest<WeChatPayQueryWorkWxRedPackResponse>
    {
        /// <summary>
        /// 商户订单号
        /// </summary>
        public string MchBillNo { get; set; }

        #region IWeChatPayCertificateRequest Members

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/mmpaymkttransfers/queryworkwxredpack";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { "mch_billno", MchBillNo },
            };
            return parameters;
        }

        public bool IsCheckResponseSign()
        {
            return true;
        }

        #endregion
    }
}
