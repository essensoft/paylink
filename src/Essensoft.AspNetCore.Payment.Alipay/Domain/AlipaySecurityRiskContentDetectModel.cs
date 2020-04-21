using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityRiskContentDetectModel Data Structure.
    /// </summary>
    public class AlipaySecurityRiskContentDetectModel : AlipayObject
    {
        /// <summary>
        /// 需要识别的文本，不要包含特殊字符以及双引号等可能引起json格式化错误问题的字符.
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }
    }
}
