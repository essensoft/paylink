using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ComplexLabelRule Data Structure.
    /// </summary>
    public class ComplexLabelRule : AlipayObject
    {
        /// <summary>
        /// 标签id
        /// </summary>
        [JsonPropertyName("label_id")]
        public string LabelId { get; set; }

        /// <summary>
        /// 标签取值，当有多个取值时用英文","分隔（比如使用in操作符时）；不允许传入下划线"_"、竖线"|"或者空格" "
        /// </summary>
        [JsonPropertyName("label_value")]
        public string LabelValue { get; set; }

        /// <summary>
        /// 目前支持EQ（等于）、NEQ（不等于）、LT（小于），GT（大于）、LTEQ（小于等于）、GTEQ（大于等于）、LIKE（匹配）、BETWEEN（范围）、IN（包含）、NOTIN（不包含）操作
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }
    }
}
