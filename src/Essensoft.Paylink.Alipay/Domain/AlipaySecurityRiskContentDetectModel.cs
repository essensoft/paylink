using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityRiskContentDetectModel Data Structure.
    /// </summary>
    public class AlipaySecurityRiskContentDetectModel : AlipayObject
    {
        /// <summary>
        /// 需要识别的文本。 注意：请勿传入包含特殊字符及双引号等，可能引起 json 格式化错误问题的字符。
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }
    }
}
