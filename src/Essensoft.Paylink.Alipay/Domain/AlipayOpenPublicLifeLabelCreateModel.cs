using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicLifeLabelCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicLifeLabelCreateModel : AlipayObject
    {
        /// <summary>
        /// 标签值类型，不填默认为 string 类型。 注意：目前只支持 string（字符串类型）。
        /// </summary>
        [JsonPropertyName("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 自定义标签名。 注意：每个生活号最多创建 100 个自定义标签。
        /// </summary>
        [JsonPropertyName("label_name")]
        public string LabelName { get; set; }
    }
}
