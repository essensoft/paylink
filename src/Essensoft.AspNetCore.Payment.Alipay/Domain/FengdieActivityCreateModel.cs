using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FengdieActivityCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class FengdieActivityCreateModel : AlipayObject
    {
        /// <summary>
        /// 云凤蝶站点的 id
        /// </summary>
        [JsonProperty("activity_id")]
        [XmlElement("activity_id")]
        public long ActivityId { get; set; }
    }
}
