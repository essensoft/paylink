using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LabelForOpenapi Data Structure.
    /// </summary>
    public class LabelForOpenapi : AlipayObject
    {
        /// <summary>
        /// 标记类型
        /// </summary>
        [JsonPropertyName("label_type")]
        public string LabelType { get; set; }

        /// <summary>
        /// 标记类型的值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
