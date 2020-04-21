using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppPdeductPayResponse.
    /// </summary>
    public class AlipayEbppPdeductPayResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝代扣协议ID
        /// </summary>
        [JsonPropertyName("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 支付宝订单流水号
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [JsonPropertyName("extend_field")]
        public string ExtendField { get; set; }

        /// <summary>
        /// 商户代扣业务流水
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 针对于支付失败时，给的对应错误明细，如果判断外围的错误码是INVOKE_PAYACCEPTANCE_EXCEPTION需要近一步再结合着结果模型中的result_code, result_msg来判断
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 针对于支付失败时，给的对应错误明细，如果判断外围的错误码是INVOKE_PAYACCEPTANCE_EXCEPTION需要近一步再结合着结果模型中的result_code, result_msg来判断
        /// </summary>
        [JsonPropertyName("result_msg")]
        public string ResultMsg { get; set; }

        /// <summary>
        /// 订单支付状态。  0：未知  1：成功  2：失败
        /// </summary>
        [JsonPropertyName("result_status")]
        public string ResultStatus { get; set; }
    }
}
