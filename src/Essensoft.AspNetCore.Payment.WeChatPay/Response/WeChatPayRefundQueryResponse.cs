using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Response
{
    public class WeChatPayRefundQueryResponse : WeChatPayResponse
    {
        /// <summary>
        /// 订单总退款次数	
        /// </summary>
        [XmlElement("total_refund_count")]
        public int TotalRefundCount { get; set; }

        /// <summary>
        /// 微信支付订单号	
        /// </summary>
        [XmlElement("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// 商户订单号	
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [XmlElement("total_fee")]
        public int TotalFee { get; set; }

        /// <summary>
        /// 应结订单金额
        /// </summary>
        [XmlElement("settlement_total_fee")]
        public int SettlementTotalFee { get; set; }

        /// <summary>
        /// 货币种类
        /// </summary>
        [XmlElement("fee_type")]
        public string FeeType { get; set; }

        /// <summary>
        /// 现金支付金额	
        /// </summary>
        [XmlElement("cash_fee")]
        public int CashFee { get; set; }

        /// <summary>
        /// 退款笔数
        /// </summary>
        [XmlElement("refund_count")]
        public string RefundCount { get; set; }
    }
}
