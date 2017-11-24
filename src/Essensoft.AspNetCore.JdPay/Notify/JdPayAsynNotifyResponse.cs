using Essensoft.AspNetCore.JdPay.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.JdPay.Notify
{
    [XmlRoot("jdpay")]
    public class JdPayAsynNotifyResponse : JdPayResponse
    {
        /// <summary>
        /// 交易流水  数字或字母
        /// </summary>
        [XmlElement("tradeNum")]
        public string TradeNum { set; get; }

        /// <summary>
        /// 交易类型
        /// 0:消费,1:退款
        /// </summary>
        [XmlElement("tradeType")]
        public string TradeType { set; get; }

        // 消费相关字段

        /// <summary>
        /// 交易列表
        /// </summary>
        [XmlElement("payList")]
        public List<PayTradeVo> PayList { set; get; }

        // 退款相关字段

        /// <summary>
        /// 原交易流水号
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
