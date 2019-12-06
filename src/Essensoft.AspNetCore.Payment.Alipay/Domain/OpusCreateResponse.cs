using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OpusCreateResponse Data Structure.
    /// </summary>
    public class OpusCreateResponse : AlipayObject
    {
        /// <summary>
        /// 作品外部id
        /// </summary>
        [JsonPropertyName("external_opus_id")]
        public string ExternalOpusId { get; set; }

        /// <summary>
        /// 作品id
        /// </summary>
        [JsonPropertyName("opus_id")]
        public string OpusId { get; set; }
    }
}
