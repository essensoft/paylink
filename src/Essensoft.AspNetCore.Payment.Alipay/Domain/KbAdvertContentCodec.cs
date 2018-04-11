using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbAdvertContentCodec Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertContentCodec : AlipayObject
    {
        /// <summary>
        /// 二维码广告内容
        /// </summary>
        [JsonProperty("url")]
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
