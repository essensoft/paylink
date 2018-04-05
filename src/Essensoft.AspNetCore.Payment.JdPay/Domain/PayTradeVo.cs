using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.JdPay.Domain
{
    public class PayTradeVo
    {
        /// <summary>
        /// 支付方式
        /// </summary>
        [XmlElement("payType")]
        public string PayType { get; set; }

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
        /// 交易时间 yyyyMMddHHmmss
        /// </summary>
        [XmlElement("tradeTime")]
        public string TradeTime { get; set; }

        /// <summary>
        /// 支付明细，不同支付方式的明细信息也不同
        /// </summary>
        [XmlElement("detail")]
        public PayTradeDetail Detail { get; set; }
    }
}