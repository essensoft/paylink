using Essensoft.AspNetCore.Payment.JdPay.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.JdPay.Notify
{
    [XmlRoot("jdpay")]
    public class JdPayAsyncNotifyResponse : JdPayNotifyResponse
    {
        /// <summary>
        /// 交易流水  数字或字母
        /// </summary>
        [XmlElement("tradeNum")]
        public string TradeNum { get; set; }

        /// <summary>
        /// 交易类型
        /// 0:消费,1:退款
        /// </summary>
        [XmlElement("tradeType")]
        public string TradeType { get; set; }

        // 消费相关字段

        /// <summary>
        /// 交易列表
        /// </summary>
        [XmlArray("payList")]
        [XmlArrayItem("pay")]
        public List<PayTradeVo> PayList { get; set; }

        // 退款相关字段

        /// <summary>
        /// 原交易流水号
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
