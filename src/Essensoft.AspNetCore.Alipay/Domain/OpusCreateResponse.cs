using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// OpusCreateResponse Data Structure.
    /// </summary>
    public class OpusCreateResponse : AlipayObject
    {
        /// <summary>
        /// 作品外部id
        /// </summary>
        [JsonProperty("external_opus_id")]
        public string ExternalOpusId { get; set; }

        /// <summary>
        /// 作品id
        /// </summary>
        [JsonProperty("opus_id")]
        public string OpusId { get; set; }
    }
}
