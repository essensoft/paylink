using System.Xml.Serialization;

namespace Essensoft.AspNetCore.WeChatPay.Response
{
    public class WeChatPayPayBankResponse : WeChatPayResponse
    {
        /// <summary>
        /// 商户企业付款单号
        /// </summary>
        [XmlElement("partner_trade_no")]
        public string PartnerTradeNo { get; set; }

        /// <summary>
        /// 代付金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 微信企业付款单号
        /// </summary>
        [XmlElement("payment_no")]
        public string PaymentNo { get; set; }

        /// <summary>
        /// 手续费金额
        /// </summary>
        [XmlElement("cmms_amt")]
        public string CmmsAmt { get; set; }
    }
}
