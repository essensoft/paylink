using System.Xml.Serialization;

namespace Essensoft.AspNetCore.WeChatPay.Response
{
    public class WeChatPayTransfersResponse : WeChatPayResponse
    {
        /// <summary>
        /// 商户号ID
        /// </summary>
        [XmlElement("mch_appid")]
        public string MchAppId { get; set; }

        /// <summary>
        /// 商户号ID
        /// </summary>
        [XmlElement("mchid")]
        public new string MchId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("partner_trade_no")]
        public string PartnerTradeNo { get; set; }

        /// <summary>
        /// 微信订单号
        /// </summary>
        [XmlElement("payment_no")]
        public string PaymentNo { get; set; }

        /// <summary>
        /// 微信支付成功时间	
        /// </summary>
        [XmlElement("payment_time")]
        public string PaymentTime { get; set; }
    }
}
