using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// 企业支付 - 查询付款记录
    /// </summary>
    public class WeChatPayQueryWwSpTrans2PockeRequest : IWeChatPayCertificateRequest<WeChatPayQueryWwSpTrans2PockeResponse>
    {
        /// <summary>
        /// 公众账号appid
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string PartnerTradeNo { get; set; }

        #region IWeChatPayCertificateRequest Members

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/mmpaymkttransfers/promotion/querywwsptrans2pocket";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { "appid", AppId },
                { "partner_trade_no", PartnerTradeNo },
            };
            return parameters;
        }

        public bool IsCheckResponseSign()
        {
            return false;
        }

        #endregion
    }
}