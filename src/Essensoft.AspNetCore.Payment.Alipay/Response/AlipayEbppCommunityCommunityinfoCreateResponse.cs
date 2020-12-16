using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppCommunityCommunityinfoCreateResponse.
    /// </summary>
    public class AlipayEbppCommunityCommunityinfoCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 小区名字拼音首字母大写+YYYYMMDD+防重位
        /// </summary>
        [JsonPropertyName("community_short_name")]
        public string CommunityShortName { get; set; }

        /// <summary>
        /// 支付宝app中的该小区跳转地址
        /// </summary>
        [JsonPropertyName("community_url")]
        public string CommunityUrl { get; set; }
    }
}
