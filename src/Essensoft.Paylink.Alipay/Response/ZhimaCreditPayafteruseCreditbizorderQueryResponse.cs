using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditPayafteruseCreditbizorderQueryResponse.
    /// </summary>
    public class ZhimaCreditPayafteruseCreditbizorderQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 订单创建时间
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 芝麻开通协议号
        /// </summary>
        [JsonPropertyName("credit_agreement_id")]
        public string CreditAgreementId { get; set; }

        /// <summary>
        /// 先享后付记账单号
        /// </summary>
        [JsonPropertyName("credit_biz_order_id")]
        public string CreditBizOrderId { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [JsonPropertyName("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 先享后付记账单冻结金额
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 记账单交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 芝麻服务ID
        /// </summary>
        [JsonPropertyName("zm_service_id")]
        public string ZmServiceId { get; set; }
    }
}
