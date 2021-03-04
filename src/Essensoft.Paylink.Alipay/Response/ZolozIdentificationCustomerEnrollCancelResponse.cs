using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
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
