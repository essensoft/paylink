using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.JDPay.Notify
{
    [XmlRoot("jdpay")]
    public class JDPaySyncReturnResponse : JDPayNotifyResponse
    {
        /// <summary>
        /// 交易流水号
        /// </summary>
        [XmlElement("tradeNum")]
        public string TradeNum { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 货币种类
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

        /// <summary>
        /// 交易信息签名
        /// </summary>
        [XmlElement("sign")]
        public string Sign { get; set; }
    }
}
