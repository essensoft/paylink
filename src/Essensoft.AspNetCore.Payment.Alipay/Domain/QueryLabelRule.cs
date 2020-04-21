using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// QueryLabelRule Data Structure.
    /// </summary>
    public class QueryLabelRule : AlipayObject
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
        /// 标签值，多值会用英文逗号分隔
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
