using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdPromotepageQueryModel Data Structure.
    /// </summary>
    public class AlipayDataDataserviceAdPromotepageQueryModel : AlipayObject
    {
        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [JsonPropertyName("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 灯火商家ID
        /// </summary>
        [JsonPropertyName("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 推广页类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
