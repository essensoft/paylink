using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayBossFncUserinvoiceinfoCreateResponse.
    /// </summary>
    public class AlipayBossFncUserinvoiceinfoCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 开票资料id，唯一性ID
        /// </summary>
        [JsonPropertyName("result_set")]
        public string ResultSet { get; set; }
    }
}
