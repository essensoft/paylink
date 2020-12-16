using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInstserviceDeductConsultResponse.
    /// </summary>
    public class AlipayEbppInstserviceDeductConsultResponse : AlipayResponse
    {
        /// <summary>
        /// true代表可签约，false代表不可签约
        /// </summary>
        [JsonPropertyName("allow_sign")]
        public string AllowSign { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 扩展字段（JSON格式）
        /// </summary>
        [JsonPropertyName("extend_field")]
        public string ExtendField { get; set; }

        /// <summary>
        /// 支付模式（PREPAID表示预付费，POSTPAID表示后付费）
        /// </summary>
        [JsonPropertyName("pay_mode")]
        public string PayMode { get; set; }
    }
}
