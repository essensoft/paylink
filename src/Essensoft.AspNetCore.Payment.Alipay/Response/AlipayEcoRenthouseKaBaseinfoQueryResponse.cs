using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoRenthouseKaBaseinfoQueryResponse.
    /// </summary>
    public class AlipayEcoRenthouseKaBaseinfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 返回kaCode唯一标识
        /// </summary>
        [JsonPropertyName("ka_code")]
        public string KaCode { get; set; }

        /// <summary>
        /// ka名称
        /// </summary>
        [JsonPropertyName("ka_name")]
        public string KaName { get; set; }

        /// <summary>
        /// 是否生效 1:生效 0:没有生效
        /// </summary>
        [JsonPropertyName("valid")]
        public string Valid { get; set; }
    }
}
