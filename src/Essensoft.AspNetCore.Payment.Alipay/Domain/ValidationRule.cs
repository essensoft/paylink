using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ValidationRule Data Structure.
    /// </summary>
    [Serializable]
    public class ValidationRule : AlipayObject
    {
        /// <summary>
        /// 规则校验对应的错误提示 如：户号必须为10位数字
        /// </summary>
        [JsonProperty("error_msg")]
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 正则表达式规则 如十位数字的正则表达式为：^\d{10}$
        /// </summary>
        [JsonProperty("rule_text")]
        [XmlElement("rule_text")]
        public string RuleText { get; set; }
    }
}
