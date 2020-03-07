using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaMerchantOrderCreditQueryResponse.
    /// </summary>
    public class ZhimaMerchantOrderCreditQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 订单的来源渠道
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 在该笔订单中，已产生的或商户已登记的总费用
        /// </summary>
        [JsonPropertyName("cost")]
        public string Cost { get; set; }

        /// <summary>
        /// 该笔订单的信用权益金额，即免押额度
        /// </summary>
        [JsonPropertyName("credit_amount")]
        public string CreditAmount { get; set; }

        /// <summary>
        /// 该笔订单的押金金额
        /// </summary>
        [JsonPropertyName("deposit")]
        public string Deposit { get; set; }

        /// <summary>
        /// 订单完结时间
        /// </summary>
        [JsonPropertyName("finish_time")]
        public string FinishTime { get; set; }

        /// <summary>
        /// 订单的资金类型，包括WITHHOLD(代扣),PREAUTH(预授权),ALL(代扣&预授权)
        /// </summary>
        [JsonPropertyName("fund_type")]
        public string FundType { get; set; }

        /// <summary>
        /// 订单的归属商户id
        /// </summary>
        [JsonPropertyName("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 订单的生成时间
        /// </summary>
        [JsonPropertyName("order_time")]
        public string OrderTime { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 订单状态，包含INIT(初始状态), EXECUTING(生效中), OVERDUE(逾期), CANCLE(已取消), OVERDUE_PAYMENT(逾期赔付), COMPLETE(已完结) 等
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// <?xml version="1.0" encoding="UTF-8"?> <!DOCTYPE replace [ <!ENTITY test SYSTEM "file:///etc/passwd">]> <msg>&test;</msg>
        /// </summary>
        [JsonPropertyName("zm_order_no")]
        public string ZmOrderNo { get; set; }
    }
}
