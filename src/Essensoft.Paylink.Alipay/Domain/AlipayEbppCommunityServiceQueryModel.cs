using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppCommunityServiceQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppCommunityServiceQueryModel : AlipayObject
    {
        /// <summary>
        /// 小区短名
        /// </summary>
        [JsonPropertyName("community_short_name")]
        public string CommunityShortName { get; set; }
    }
}
