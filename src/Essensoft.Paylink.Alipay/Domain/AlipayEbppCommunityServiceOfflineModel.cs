using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppCommunityServiceOfflineModel Data Structure.
    /// </summary>
    public class AlipayEbppCommunityServiceOfflineModel : AlipayObject
    {
        /// <summary>
        /// 小区短名
        /// </summary>
        [JsonPropertyName("community_short_name")]
        public string CommunityShortName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// THIRD_PARTY_COMMUNITY_JIAOFEI:物业缴费 CENTRAL_SCAN_CODE_PASS:中心化扫码通行 THIRD_PARTY_SCAN_CODE_PASS:三方扫码通行
        /// </summary>
        [JsonPropertyName("service_type")]
        public string ServiceType { get; set; }
    }
}
