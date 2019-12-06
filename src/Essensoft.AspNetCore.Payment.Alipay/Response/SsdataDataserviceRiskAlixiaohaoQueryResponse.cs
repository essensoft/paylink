using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// SsdataDataserviceRiskAlixiaohaoQueryResponse.
    /// </summary>
    public class SsdataDataserviceRiskAlixiaohaoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否阿里小号
        /// </summary>
        [JsonPropertyName("is_alixiaohao")]
        public bool IsAlixiaohao { get; set; }
    }
}
