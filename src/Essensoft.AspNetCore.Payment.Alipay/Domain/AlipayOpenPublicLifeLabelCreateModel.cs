using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicLifeLabelCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicLifeLabelCreateModel : AlipayObject
    {
        /// <summary>
        /// 标签值类型，目前只支持string（字符串类型），不传默认为"string"
        /// </summary>
        [JsonPropertyName("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 自定义标签名
        /// </summary>
        [JsonPropertyName("label_name")]
        public string LabelName { get; set; }
    }
}
