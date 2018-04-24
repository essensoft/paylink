using Essensoft.AspNetCore.Payment.JDPay.Domain;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.JDPay.Response
{
    [XmlRoot("jdpay")]
    public class JDPayRefundResponse : JDPayResponse
    {
        /// <summary>
        /// 版本号
        /// </summary>
        [XmlElement("version")]
        public string Version { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        [XmlElement("merchant")]
        public string Merchant { get; set; }

        /// <summary>
        /// 门店号
        /// </summary>
        [XmlElement("device")]
        public string Device { get; set; }

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
        /// 返回信息
        /// </summary>
        [XmlElement("result")]
        public Result Result { get; set; }

        /// <summary>
        /// 交易信息签名	
        /// </summary>
        [XmlElement("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// 原交易流水
        /// </summary>
        [XmlElement("oTradeNum")]
        public string OTradeNum { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

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
