using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Notify
{
    /// <summary>
    /// 当面付异步通知-仅用于扫码支付
    /// 更新时间：2019-08-07
    /// https://docs.open.alipay.com/194/103296/
    /// </summary>
    public class AlipayTradePrecreateNotify : AlipayNotify
    {
        // 公共参数

        /// <summary>
        /// 通知时间
        /// </summary>
        [JsonProperty("notify_time")]
        public string NotifyTime { get; set; }

        /// <summary>
        /// 通知类型
        /// </summary>
        [JsonProperty("notify_type")]
        public string NotifyType { get; set; }

        /// <summary>
        /// 通知校验ID
        /// </summary>
        [JsonProperty("notify_id")]
        public string NotifyId { get; set; }

        /// <summary>
        /// 签名类型
        /// </summary>
        [JsonProperty("sign_type")]
        public string SignType { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [JsonProperty("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonProperty("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 开发者的app_id
        /// </summary>
        [JsonProperty("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonProperty("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 商户业务号
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 买家支付宝用户号
        /// </summary>
        [JsonProperty("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家支付宝账号
        /// </summary>
        [JsonProperty("buyer_logon_id")]
        public string BuyerLogonId { get; set; }

        /// <summary>
        /// 卖家支付宝用户号
        /// </summary>
        [JsonProperty("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 卖家支付宝账号
        /// </summary>
        [JsonProperty("seller_email")]
        public string SellerEmail { get; set; }

        /// <summary>
        /// 交易状态
        /// </summary>
        [JsonProperty("trade_status")]
        public string TradeStatus { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [JsonProperty("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 实收金额
        /// </summary>
        [JsonProperty("receipt_amount")]
        public string ReceiptAmount { get; set; }

        /// <summary>
        /// 开票金额
        /// </summary>
        [JsonProperty("invoice_amount")]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 付款金额
        /// </summary>
        [JsonProperty("buyer_pay_amount")]
        public string BuyerPayAmount { get; set; }

        /// <summary>
        /// 集分宝金额
        /// </summary>
        [JsonProperty("point_amount")]
        public string PointAmount { get; set; }

        /// <summary>
        /// 总退款金额
        /// </summary>
        [JsonProperty("refund_fee")]
        public string RefundFee { get; set; }

        /// <summary>
        /// 实际退款金额
        /// </summary>
        [JsonProperty("send_back_fee")]
        public string SendBackFee { get; set; }

        /// <summary>
        /// 订单标题
        /// </summary>
        [JsonProperty("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [JsonProperty("body")]
        public string Body { get; set; }

        /// <summary>
        /// 交易创建时间
        /// </summary>
        [JsonProperty("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 交易付款时间
        /// </summary>
        [JsonProperty("gmt_payment")]
        public string GmtPayment { get; set; }

        /// <summary>
        /// 交易退款时间
        /// </summary>
        [JsonProperty("gmt_refund")]
        public string GmtRefund { get; set; }

        /// <summary>
        /// 交易结束时间
        /// </summary>
        [JsonProperty("gmt_close")]
        public string GmtClose { get; set; }

        /// <summary>
        /// 支付金额信息
        /// </summary>
        [JsonProperty("fund_bill_list")]
        public string FundBillList { get; set; }
    }
}
