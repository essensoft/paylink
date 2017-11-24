using Essensoft.AspNetCore.WeChatPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.WeChatPay.Request
{
    public class WeChatPayGetTransferInfoRequest : IWeChatPayCertificateRequest<WeChatPayGetTransferInfoResponse>
    {
        /// <summary>
        /// 商户订单号
        /// </summary>
        public string PartnerTradeNo { get; set; }

        #region IWeChatPayRequest Members

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/mmpaymkttransfers/gettransferinfo";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary()
            {
                { "partner_trade_no", PartnerTradeNo }
            };
            return parameters;
        }

        public bool GetIsTransfers()
        {
            return false;
        }

        public bool GetIsBank()
        {
            return false;
        }

        public bool GetIsPayBank()
        {
            return false;
        }

        #endregion
    }
}
