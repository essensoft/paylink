using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LabelRule Data Structure.
    /// </summary>
    public class LabelRule : AlipayObject
    {
        /// <summary>
        /// 标签id
        /// </summary>
        [JsonPropertyName("label_id")]
        public string LabelId { get; set; }

        /// <summary>
        /// 标签值，当有多个取值时用英文","分隔，不允许传入下划线"_"、竖线"|"或者空格" "和方括号"["、"]"
        /// </summary>
        [JsonPropertyName("label_value")]
        public string LabelValue { get; set; }

        /// <summary>
        /// 目前支持EQ（等于）、BETWEEN（范围）、IN（包含）三种操作符；每个标签支持的运算符可以通过<a href="https://docs.open.alipay.com/api_6/alipay.open.public.life.label.batchquery#sintq">标签列表查询接口</a>获得。该字段允许为空，默认运算符为IN
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }
    }
}
