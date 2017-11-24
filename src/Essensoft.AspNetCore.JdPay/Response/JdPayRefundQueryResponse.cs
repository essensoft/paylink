using System.Xml.Serialization;

namespace Essensoft.AspNetCore.JdPay.Response
{
    [XmlRoot("jdpay")]
    public class JdPayRefundQueryResponse : JdPayResponse
    {
        /// <summary>
        /// 交易流水
        /// </summary>
        [XmlElement("tradeNum")]
        public string TradeNum { set; get; }

        /// <summary>
        /// 交易类型
        /// </summary>
        [XmlElement("tradeType")]
        public string TradeType { set; get; }

        /// <summary>
        /// 原交易流水
        /// </summary>
        [XmlElement("oTradeNum")]
        public string OTradeNum { set; get; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [XmlElement("amount")]
        public long Amount { set; get; }

        /// <summary>
        /// 交易币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { set; get; }

        /// <summary>
        /// 交易时间
        /// </summary>
        [XmlElement("tradeTime")]
        public string TradeTime { set; get; }

        /// <summary>
        /// 交易备注
        /// </summary>
        [XmlElement("note")]
        public string Note { set; get; }

        /// <summary>
        /// 交易状态
        /// </summary>
        [XmlElement("status")]
        public string Status { set; get; }
    }
}
