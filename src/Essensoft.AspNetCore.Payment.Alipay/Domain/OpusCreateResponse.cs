using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OpusCreateResponse Data Structure.
    /// </summary>
    [Serializable]
    public class OpusCreateResponse : AlipayObject
    {
        /// <summary>
        /// 作品外部id
        /// </summary>
        [JsonProperty("external_opus_id")]
        [XmlElement("external_opus_id")]
        public string ExternalOpusId { get; set; }

        /// <summary>
        /// 作品id
        /// </summary>
        [JsonProperty("opus_id")]
        [XmlElement("opus_id")]
        public string OpusId { get; set; }
    }
}
