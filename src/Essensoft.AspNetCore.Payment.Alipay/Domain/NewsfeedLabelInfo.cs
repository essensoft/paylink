using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// NewsfeedLabelInfo Data Structure.
    /// </summary>
    public class NewsfeedLabelInfo : AlipayObject
    {
        /// <summary>
        /// 根据主谓宾的格式生成动态的标题，此字段为谓语
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// label行的跳转链接
        /// </summary>
        [JsonPropertyName("scheme")]
        public string Scheme { get; set; }

        /// <summary>
        /// 根据主谓宾的格式生成动态的标题，此字段为宾语
        /// </summary>
        [JsonPropertyName("target")]
        public string Target { get; set; }
    }
}
