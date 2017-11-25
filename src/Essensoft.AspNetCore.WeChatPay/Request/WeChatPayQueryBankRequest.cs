using Essensoft.AspNetCore.WeChatPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.WeChatPay.Request
{
    public class WeChatPayQueryBankRequest : IWeChatPayCertificateRequest<WeChatPayQueryBankResponse>
    {
        /// <summary>
        /// 商户企业付款单号
        /// </summary>
        public string PartnerTradeNo { get; set; }

        #region IWeChatPayRequest Members

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/mmpaysptrans/query_bank";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary()
            {
                { "partner_trade_no", PartnerTradeNo }
            };
            return parameters;
        }

        #endregion
    }
}
