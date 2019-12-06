using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogVoiceMediaaudioUploadResponse.
    /// </summary>
    public class AlipayMsaasMediarecogVoiceMediaaudioUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("extinfo_a")]
        public string ExtinfoA { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("extinfo_b")]
        public string ExtinfoB { get; set; }

        /// <summary>
        /// 结果memo
        /// </summary>
        [JsonPropertyName("result_memo")]
        public string ResultMemo { get; set; }

        /// <summary>
        /// 结果状态
        /// </summary>
        [JsonPropertyName("result_status")]
        public string ResultStatus { get; set; }
    }
}
