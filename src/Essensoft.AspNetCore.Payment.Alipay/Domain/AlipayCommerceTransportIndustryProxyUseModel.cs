using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportIndustryProxyUseModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportIndustryProxyUseModel : AlipayObject
    {
        /// <summary>
        /// 描述当前行业代理请求的请求事件
        /// </summary>
        [JsonPropertyName("industry_event")]
        public string IndustryEvent { get; set; }

        /// <summary>
        /// 行业代理请求的业务请求内容，根据行业场景、行业事件的变化而不同
        /// </summary>
        [JsonPropertyName("industry_request")]
        public string IndustryRequest { get; set; }

        /// <summary>
        /// 描述当前行业代理请求的请求场景
        /// </summary>
        [JsonPropertyName("industry_scene")]
        public string IndustryScene { get; set; }

        /// <summary>
        /// 支持商户接入此业务的系统服务商id
        /// </summary>
        [JsonPropertyName("sys_service_provider_id")]
        public string SysServiceProviderId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
