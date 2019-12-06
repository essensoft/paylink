using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogVoiceMediaaudioUploadModel Data Structure.
    /// </summary>
    public class AlipayMsaasMediarecogVoiceMediaaudioUploadModel : AlipayObject
    {
        /// <summary>
        /// base64编码的声音数据
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

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
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("extinfo_c")]
        public string ExtinfoC { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("extinfo_d")]
        public string ExtinfoD { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [JsonPropertyName("labeltime")]
        public string Labeltime { get; set; }

        /// <summary>
        /// 媒体名称
        /// </summary>
        [JsonPropertyName("vname")]
        public string Vname { get; set; }

        /// <summary>
        /// 媒体类型
        /// </summary>
        [JsonPropertyName("vtype")]
        public string Vtype { get; set; }
    }
}
