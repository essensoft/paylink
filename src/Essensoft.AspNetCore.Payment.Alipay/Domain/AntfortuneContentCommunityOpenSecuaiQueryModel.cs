using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntfortuneContentCommunityOpenSecuaiQueryModel Data Structure.
    /// </summary>
    public class AntfortuneContentCommunityOpenSecuaiQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务的请求参数
        /// </summary>
        [JsonPropertyName("biz_request")]
        public string BizRequest { get; set; }

        /// <summary>
        /// 请求的业务类型
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [JsonPropertyName("tenant_id")]
        public string TenantId { get; set; }
    }
}
