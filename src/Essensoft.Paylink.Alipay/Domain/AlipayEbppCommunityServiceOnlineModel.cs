using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppCommunityServiceOnlineModel Data Structure.
    /// </summary>
    public class AlipayEbppCommunityServiceOnlineModel : AlipayObject
    {
        /// <summary>
        /// 小区短名
        /// </summary>
        [JsonPropertyName("community_short_name")]
        public string CommunityShortName { get; set; }

        /// <summary>
        /// 服务类型
        /// </summary>
        [JsonPropertyName("service_type")]
        public string ServiceType { get; set; }
    }
}
