using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTradeFastpayRefundQueryResponse.
    /// </summary>
    public class AlipayTradeFastpayRefundQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 银行卡冲退信息
        /// </summary>
        [JsonPropertyName("deposit_back_info")]
        public DepositBackInfo DepositBackInfo { get; set; }

        /// <summary>
        /// 退款失败错误码。只在使用异步退款接口情况下才会返回该字段
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 退款时间；  默认不返回该信息，需与支付宝约定后配置返回；
        /// </summary>
        [JsonPropertyName("gmt_refund_pay")]
        public string GmtRefundPay { get; set; }

        /// <summary>
        /// 行业特殊信息（例如在医保卡支付退款中，医保局向商户返回医疗信息）。
        /// </summary>
        [JsonPropertyName("industry_sepc_detail")]
        public string IndustrySepcDetail { get; set; }

        /// <summary>
        /// 本笔退款对应的退款请求号
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 创建交易传入的商户订单号
        /// </summary>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 本次退款金额中买家退款金额
        /// </summary>
        [JsonPropertyName("present_refund_buyer_amount")]
        public string PresentRefundBuyerAmount { get; set; }

        /// <summary>
        /// 本次退款金额中平台优惠退款金额
        /// </summary>
        [JsonPropertyName("present_refund_discount_amount")]
        public string PresentRefundDiscountAmount { get; set; }

        /// <summary>
        /// 本次退款金额中商家优惠退款金额
        /// </summary>
        [JsonPropertyName("present_refund_mdiscount_amount")]
        public string PresentRefundMdiscountAmount { get; set; }

        /// <summary>
        /// 本次退款请求，对应的退款金额
        /// </summary>
        [JsonPropertyName("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 本次退款针对收款方的退收费金额；  默认不返回该信息，需与支付宝约定后配置返回；
        /// </summary>
        [JsonPropertyName("refund_charge_amount")]
        public string RefundChargeAmount { get; set; }

        /// <summary>
        /// 本次退款使用的资金渠道； 默认不返回该信息，需与支付宝约定后配置，或者入参的query_options中指定时才返回该字段信息。
        /// </summary>
        [JsonPropertyName("refund_detail_item_list")]
        public List<TradeFundBill> RefundDetailItemList { get; set; }

        /// <summary>
        /// 发起退款时，传入的退款原因
        /// </summary>
        [JsonPropertyName("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 退分账明细信息
        /// </summary>
        [JsonPropertyName("refund_royaltys")]
        public List<RefundRoyaltyResult> RefundRoyaltys { get; set; }

        /// <summary>
        /// 退款清算编号，用于清算对账使用；  只在银行间联交易场景下返回该信息；
        /// </summary>
        [JsonPropertyName("refund_settlement_id")]
        public string RefundSettlementId { get; set; }

        /// <summary>
        /// 只在使用异步退款接口情况下才返回该字段。REFUND_PROCESSING 退款处理中；REFUND_SUCCESS 退款处理成功；REFUND_FAIL 退款失败;
        /// </summary>
        [JsonPropertyName("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 本次商户实际退回金额；  默认不返回该信息，需与支付宝约定后配置返回；
        /// </summary>
        [JsonPropertyName("send_back_fee")]
        public string SendBackFee { get; set; }

        /// <summary>
        /// 该笔退款所对应的交易的订单金额
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
