using Essensoft.AspNetCore.Payment.WeChatPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// 查询企业付款
    /// </summary>
    public class WeChatPayGetTransferInfoRequest : IWeChatPayCertificateRequest<WeChatPayGetTransferInfoResponse>
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string PartnerTradeNo { get; set; }

        #region IWeChatPayCertificateRequest Members

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/mmpaymkttransfers/gettransferinfo";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary()
            {
                { "appid", AppId },
                { "partner_trade_no", PartnerTradeNo },
            };
            return parameters;
        }

        #endregion
    }
}
