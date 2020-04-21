using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdGroupQueryModel Data Structure.
    /// </summary>
    public class AlipayDataDataserviceAdGroupQueryModel : AlipayObject
    {
        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [JsonPropertyName("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 外部唯一单元编号
        /// </summary>
        [JsonPropertyName("group_outer_id")]
        public string GroupOuterId { get; set; }
    }
}
