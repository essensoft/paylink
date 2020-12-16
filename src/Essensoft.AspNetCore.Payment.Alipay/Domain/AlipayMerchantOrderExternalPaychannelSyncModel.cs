using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMerchantOrderExternalPaychannelSyncModel Data Structure.
    /// </summary>
    public class AlipayMerchantOrderExternalPaychannelSyncModel : AlipayObject
    {
        /// <summary>
        /// 业务单号，微信、支付宝交易号
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 业务单状态
        /// </summary>
        [JsonPropertyName("biz_status")]
        public string BizStatus { get; set; }

        /// <summary>
        /// 买家实付金额 - 仅针对支付
        /// </summary>
        [JsonPropertyName("buyer_pay_amount")]
        public string BuyerPayAmount { get; set; }

        /// <summary>
        /// 平台优惠金额 - 仅针对支付
        /// </summary>
        [JsonPropertyName("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 交易支付使用的资金渠道
        /// </summary>
        [JsonPropertyName("fund_bill_list")]
        public string FundBillList { get; set; }

        /// <summary>
        /// 支付成功时间 - 仅针对支付
        /// </summary>
        [JsonPropertyName("gmt_payment")]
        public string GmtPayment { get; set; }

        /// <summary>
        /// 商家优惠金额 - 仅针对支付
        /// </summary>
        [JsonPropertyName("mdiscount_amount")]
        public string MdiscountAmount { get; set; }

        /// <summary>
        /// 通知时间
        /// </summary>
        [JsonPropertyName("notify_time")]
        public string NotifyTime { get; set; }

        /// <summary>
        /// 通知类型
        /// </summary>
        [JsonPropertyName("notify_type")]
        public string NotifyType { get; set; }

        /// <summary>
        /// 原始第三方支付结构的交易号，比如支付宝、微信交易号
        /// </summary>
        [JsonPropertyName("origin_trade_no")]
        public string OriginTradeNo { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 外部请求号 - 仅针对退款
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 支付渠道，微信：wechat，支付宝：alipay - 仅针对支付
        /// </summary>
        [JsonPropertyName("pay_channel")]
        public string PayChannel { get; set; }

        /// <summary>
        /// 实收金额 - 仅针对支付
        /// </summary>
        [JsonPropertyName("receipt_amount")]
        public string ReceiptAmount { get; set; }

        /// <summary>
        /// 本次退款金额（非累计） - 仅针对退款
        /// </summary>
        [JsonPropertyName("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 累计退款总金额 - 仅针对退款
        /// </summary>
        [JsonPropertyName("refund_total_amount")]
        public string RefundTotalAmount { get; set; }

        /// <summary>
        /// 业务单总金额
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }
    }
}
