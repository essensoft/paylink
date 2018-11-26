using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CodeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CodeInfo : AlipayObject
    {
        /// <summary>
        /// 跳转URL，扫码关注服务窗后会直接跳转到此URL
        /// </summary>
        [JsonProperty("goto_url")]
        [XmlElement("goto_url")]
        public string GotoUrl { get; set; }

        /// <summary>
        /// 场景信息
        /// </summary>
        [JsonProperty("scene")]
        [XmlElement("scene")]
        public Scene Scene { get; set; }
    }
}
