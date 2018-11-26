using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// 企业付款到银行卡
    /// </summary>
    public class WeChatPayPayBankRequest : IWeChatPayCertificateRequest<WeChatPayPayBankResponse>
    {
        /// <summary>
        /// 商户企业付款单号
        /// </summary>
        public string PartnerTradeNo { get; set; }

        /// <summary>
        /// 收款方银行卡号
        /// </summary>
        public string EncBankNo { get; set; }

        /// <summary>
        /// 收款方用户名
        /// </summary>
        public string EncTrueName { get; set; }

        /// <summary>
        /// 收款方开户行
        /// </summary>
        public string BankCode { get; set; }

        /// <summary>
        /// 付款金额
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// 付款备注
        /// </summary>
        public string Desc { get; set; }

        #region IWeChatPayCertificateRequest Members

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/mmpaysptrans/pay_bank";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { "partner_trade_no", PartnerTradeNo},
                { "enc_bank_no", EncBankNo },
                { "enc_true_name", EncTrueName },
                { "bank_code", BankCode },
                { "amount", Amount },
                { "desc", Desc}
            };
            return parameters;
        }

        #endregion
    }
}
