using Essensoft.AspNetCore.JdPay.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.JdPay.Response
{
    [XmlRoot("jdpay")]
    public class JdPayOrderQueryResponse : JdPayResponse
    {
        /// <summary>
        /// 交易流水  数字或字母
        /// </summary>
        [XmlElement("tradeNum")]
        public string TradeNum { set; get; }

        /// <summary>
        /// 交易类型
        /// </summary>
        [XmlElement("tradeType")]
        public int TradeType { set; get; }

        /// <summary>
        /// 交易备注
        /// </summary>
        [XmlElement("note")]
        public string Note { set; get; }

        /// <summary>
        /// 支付总金额
        /// </summary>
        [XmlElement("amount")]
        public long Amount { set; get; }

        /// <summary>
        /// 交易返回状态  成功：2，失败，3
        /// </summary>
        [XmlElement("status")]
        public string Status { set; get; }

        /// <summary>
        /// 交易列表
        /// </summary>
        [XmlElement("payList")]
        public List<PayTradeVo> PayList { set; get; }
    }
}
