using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdCreativeQueryModel Data Structure.
    /// </summary>
    public class AlipayDataDataserviceAdCreativeQueryModel : AlipayObject
    {
        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [JsonPropertyName("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 外部平台导入广告库后，广告投放创意对应的外部资源ID
        /// </summary>
        [JsonPropertyName("creative_outer_id")]
        public string CreativeOuterId { get; set; }
    }
}
