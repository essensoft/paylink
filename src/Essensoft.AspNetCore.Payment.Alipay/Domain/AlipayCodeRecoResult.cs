using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCodeRecoResult Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCodeRecoResult : AlipayObject
    {
        /// <summary>
        /// 识别的验证码内容
        /// </summary>
        [JsonProperty("content")]
        [XmlElement("content")]
        public string Content { get; set; }
    }
}
