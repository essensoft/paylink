using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Notify
{
    /// <summary>
    /// 支付异步通知
    /// 根据文档：https://opensupport.alipay.com/support/knowledge/36780/201602409820?ant_source=zsearch
    /// 参考PDF：https://gw.alipayobjects.com/os/rmsportal/UkoSRNhRZnSjQciiPFBu.pdf
    /// 第10页异步通知
    /// </summary>
    public class AlipayTradePayNotify : AlipayNotify
    {
        /// <summary>
        /// 支付宝分配给开发者的应用Id
        /// </summary>
        [JsonPropertyName("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// 支付宝分配给商户的应用 Id
        /// </summary>
        [JsonPropertyName("auth_app_id")]
        public string AuthAppId { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 商户业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 买家支付宝账号
        /// </summary>
        [JsonPropertyName("buyer_logon_id")]
        public string BuyerLogonId { get; set; }

        /// <summary>
        /// 卖家支付宝用户号
        /// </summary>
        [JsonPropertyName("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 卖家支付宝账号
        /// </summary>
        [JsonPropertyName("seller_email")]
        public string SellerEmail { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 买家的支付宝用户 Uid
        /// </summary>
        [JsonPropertyName("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 交易状态
        /// </summary>
        [JsonPropertyName("trade_status")]
        public string TradeStatus { get; set; }

        /// <summary>
        /// 实收金额
        /// </summary>
        [JsonPropertyName("receipt_amount")]
        public string ReceiptAmount { get; set; }

        /// <summary>
        /// 集分宝付款金额
        /// </summary>
        [JsonPropertyName("point_amount")]
        public string PointAmount { get; set; }

        /// <summary>
        /// 可给用户开具发票的金额
        /// </summary>
        [JsonPropertyName("invoice_amount")]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [JsonPropertyName("refund_fee")]
        public string RefundFee { get; set; }

        /// <summary>
        /// 用户支付金额
        /// </summary>
        [JsonPropertyName("buyer_pay_amount")]
        public string BuyerPayAmount { get; set; }

        /// <summary>
        /// 订单标题
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 订单描述
        /// </summary>
        [JsonPropertyName("body")]
        public string Body { get; set; }

        /// <summary>
        /// 交易创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 交易付款时间
        /// </summary>
        [JsonPropertyName("gmt_payment")]
        public string GmtPayment { get; set; }

        /// <summary>
        /// 交易退款时间
        /// </summary>
        [JsonPropertyName("gmt_refund")]
        public string GmtRefund { get; set; }

        /// <summary>
        /// 交易结束时间
        /// </summary>
        [JsonPropertyName("gmt_close")]
        public string GmtClose { get; set; }

        /// <summary>
        /// 支付金额信息
        /// </summary>
        [JsonPropertyName("fund_bill_list")]
        public string FundBillList { get; set; }

        /// <summary>
        /// 优惠券信息
        /// </summary>
        [JsonPropertyName("voucher_detail_list")]
        public string VoucherDetailList { get; set; }

        /// <summary>
        /// 本次交易支付所使用的单品券优惠的商品优惠信息
        /// </summary>
        [JsonPropertyName("discount_goods_detail")]
        public string DiscountGoodsDetail { get; set; }

        /// <summary>
        /// 预授权支付模式，该参数仅在信用预授权支付场景下返回。信用预授权支付：CREDIT_PREAUTH_PAY
        /// </summary>
        [JsonPropertyName("auth_trade_pay_mode")]
        public string AuthTradePayMode { get; set; }

        /// <summary>
        /// 通知校验ID
        /// </summary>
        [JsonPropertyName("notify_id")]
        public string NotifyId { get; set; }

        /// <summary>
        /// 通知时间
        /// </summary>
        [JsonPropertyName("notify_time")]
        public string NotifyTime { get; set; }

        /// <summary>
        /// 签名类型
        /// </summary>
        [JsonPropertyName("sign_type")]
        public string SignType { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [JsonPropertyName("sign")]
        public string Sign { get; set; }
    }
}
