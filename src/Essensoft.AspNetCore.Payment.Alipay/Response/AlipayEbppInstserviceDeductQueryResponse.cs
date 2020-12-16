using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInstserviceDeductQueryResponse.
    /// </summary>
    public class AlipayEbppInstserviceDeductQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 协议支付id
        /// </summary>
        [JsonPropertyName("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 当前任务状态: not_exist , processing , success , failed
        /// </summary>
        [JsonPropertyName("current_status")]
        public string CurrentStatus { get; set; }

        /// <summary>
        /// 业务错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 扩展字段（JSON格式）
        /// </summary>
        [JsonPropertyName("extend_field")]
        public string ExtendField { get; set; }
    }
}
