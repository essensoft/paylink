using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ValidationRule Data Structure.
    /// </summary>
    public class ValidationRule : AlipayObject
    {
        /// <summary>
        /// 规则校验对应的错误提示 如：户号必须为10位数字
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 正则表达式规则 如十位数字的正则表达式为：^\d{10}$
        /// </summary>
        [JsonPropertyName("rule_text")]
        public string RuleText { get; set; }
    }
}
