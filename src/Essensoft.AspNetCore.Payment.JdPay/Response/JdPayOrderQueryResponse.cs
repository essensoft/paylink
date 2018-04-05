using Essensoft.AspNetCore.Payment.JdPay.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.JdPay.Response
{
    [XmlRoot("jdpay")]
    public class JdPayOrderQueryResponse : JdPayResponse
    {
        /// <summary>
        /// 交易流水  数字或字母
        /// </summary>
        [XmlElement("tradeNum")]
        public string TradeNum { get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        [XmlElement("tradeType")]
        public int TradeType { get; set; }

        /// <summary>
        /// 交易备注
        /// </summary>
        [XmlElement("note")]
        public string Note { get; set; }

        /// <summary>
        /// 支付总金额
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 交易返回状态  成功：2，失败，3
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 交易列表
        /// </summary>
        [XmlArray("payList")]
        [XmlArrayItem("pay")]
        public List<PayTradeVo> PayList { get; set; }
    }
}
