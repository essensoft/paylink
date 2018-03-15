using System.Xml.Serialization;

namespace Essensoft.AspNetCore.JdPay.Response
{
    [XmlRoot("jdpay")]
    public class JdPayRefundResponse : JdPayResponse
    {
        /// <summary>
        /// 交易流水
        /// </summary>
        [XmlElement("tradeNum")]
        public string TradeNum { get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        [XmlElement("tradeType")]
        public string TradeType { get; set; }

        /// <summary>
        /// 原交易流水
        /// </summary>
        [XmlElement("oTradeNum")]
        public string OTradeNum { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 交易币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        [XmlElement("tradeTime")]
        public string TradeTime { get; set; }

        /// <summary>
        /// 交易备注
        /// </summary>
        [XmlElement("note")]
        public string Note { get; set; }

        /// <summary>
        /// 交易状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
