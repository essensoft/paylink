using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarTradeRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarTradeRefundModel : AlipayObject
    {
        /// <summary>
        /// 渠道平台
        /// </summary>
        [JsonProperty("isv")]
        [XmlElement("isv")]
        public string Isv { get; set; }

        /// <summary>
        /// 退款金额(分)
        /// </summary>
        [JsonProperty("refund_fee")]
        [XmlElement("refund_fee")]
        public string RefundFee { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        [JsonProperty("refund_reason")]
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 退款交易编号
        /// </summary>
        [JsonProperty("trade_no")]
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
