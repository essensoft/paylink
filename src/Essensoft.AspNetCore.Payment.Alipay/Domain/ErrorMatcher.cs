using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ErrorMatcher Data Structure.
    /// </summary>
    [Serializable]
    public class ErrorMatcher : AlipayObject
    {
        /// <summary>
        /// 失败原因
        /// </summary>
        [JsonProperty("error_msg")]
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 用户打标接口出错的匹配器
        /// </summary>
        [JsonProperty("matcher")]
        [XmlElement("matcher")]
        public Matcher Matcher { get; set; }
    }
}
