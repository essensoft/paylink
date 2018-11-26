using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoEduKtBillingModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoEduKtBillingModifyModel : AlipayObject
    {
        /// <summary>
        /// 退款时，支付宝返回的用户的登录id
        /// </summary>
        [JsonProperty("buyer_logon_id")]
        [XmlElement("buyer_logon_id")]
        public string BuyerLogonId { get; set; }

        /// <summary>
        /// 支付宝返回的买家支付宝用户id
        /// </summary>
        [JsonProperty("buyer_user_id")]
        [XmlElement("buyer_user_id")]
        public string BuyerUserId { get; set; }

        /// <summary>
        /// 本次退款是否发生了资金变化
        /// </summary>
        [JsonProperty("fund_change")]
        [XmlElement("fund_change")]
        public string FundChange { get; set; }

        /// <summary>
        /// 支付宝返回的退款时间，而不是商户退款申请的时间
        /// </summary>
        [JsonProperty("gmt_refund")]
        [XmlElement("gmt_refund")]
        public string GmtRefund { get; set; }

        /// <summary>
        /// 标识一次退款请求，同一笔交易多次退款需要保证唯一，如需部分退款，则此参数必传
        /// </summary>
        [JsonProperty("out_request_no")]
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// isv系统的订单号
        /// </summary>
        [JsonProperty("out_trade_no")]
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 需要退款的金额，该金额不能大于订单金额,单位为元，支持两位小数
        /// </summary>
        [JsonProperty("refund_amount")]
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 支付宝返回的退款资金渠道，json格式字符串
        /// </summary>
        [JsonProperty("refund_detail_item_list")]
        [XmlElement("refund_detail_item_list")]
        public string RefundDetailItemList { get; set; }

        /// <summary>
        /// 退款原因，商家根据客户实际退款原因填写
        /// </summary>
        [JsonProperty("refund_reason")]
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 状态：1:缴费成功，2:关闭账单，3、退费  如果为退款状态，需要填写以下字段,字段都是支付宝退款返回的必填参数
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 支付宝返回的交易号
        /// </summary>
        [JsonProperty("trade_no")]
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
