using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// QueryComplexLabelRule Data Structure.
    /// </summary>
    public class QueryComplexLabelRule : AlipayObject
    {
        /// <summary>
        /// 标签id
        /// </summary>
        [JsonPropertyName("label_id")]
        public string LabelId { get; set; }

        /// <summary>
        /// 标签名
        /// </summary>
        [JsonPropertyName("label_name")]
        public string LabelName { get; set; }

        /// <summary>
        /// 当有多个取值时用英文","分隔，不允许传入下划线"_"、竖线"|"或者空格" "
        /// </summary>
        [JsonPropertyName("label_value")]
        public string LabelValue { get; set; }

        /// <summary>
        /// 运算符
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }
    }
}
