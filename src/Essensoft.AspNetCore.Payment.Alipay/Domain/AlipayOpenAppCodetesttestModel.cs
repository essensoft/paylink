using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppCodetesttestModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppCodetesttestModel : AlipayObject
    {
        /// <summary>
        /// 测试参数1
        /// </summary>
        [JsonProperty("testparam")]
        [XmlElement("testparam")]
        public string Testparam { get; set; }

        /// <summary>
        /// 测试测试
        /// </summary>
        [JsonProperty("testtestparam")]
        [XmlElement("testtestparam")]
        public string Testtestparam { get; set; }
    }
}
