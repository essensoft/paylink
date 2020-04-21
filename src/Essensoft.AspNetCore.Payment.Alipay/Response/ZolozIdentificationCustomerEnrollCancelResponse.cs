using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZolozIdentificationCustomerEnrollCancelResponse.
    /// </summary>
    public class ZolozIdentificationCustomerEnrollCancelResponse : AlipayResponse
    {
        /// <summary>
        /// 与入参值保持一致
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }
    }
}
