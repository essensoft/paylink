using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.JdPay.Response
{
    [XmlRoot("jdpay")]
    public class JdPayRevokeResponse : JdPayResponse
    {
        /// <summary>
        /// 交易流水
        /// 商户唯一交易流水号。格式：字母&数字
        /// </summary>
        [XmlElement("tradeNum")]
        public string TradeNum { get; set; }

        /// <summary>
        /// 交易类型
        /// 2：撤销
        /// </summary>
        [XmlElement("tradeType")]
        public int TradeType { get; set; }

        /// <summary>
        /// 原交易流水号	
        /// 标识需要撤销的那笔交易流水。
        /// </summary>
        [XmlElement("oTradeNum")]
        public string OTradeNum { get; set; }

        /// <summary>
        /// 交易金额	
        /// 商户订单的资金总额。单位：分，大于0
        /// </summary>
        [XmlElement("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 交易币种
        /// 货币类型。固定值：CNY
        /// </summary>
        [XmlElement("currency")]
        public int Currency { get; set; }

        /// <summary>
        /// 交易时间	
        /// 订单生成时间。格式：“yyyyMMddHHmmss”
        /// </summary>
        [XmlElement("tradeTime")]
        public int TradeTime { get; set; }

        /// <summary>
        /// 商户备注信息
        /// </summary>
        [XmlElement("note")]
        public string Note { get; set; }

        /// <summary>
        /// 交易状态
        /// 1-成功 2-失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
