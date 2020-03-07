using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntfortuneContentCommunityHoteventListQueryModel Data Structure.
    /// </summary>
    public class AntfortuneContentCommunityHoteventListQueryModel : AlipayObject
    {
        /// <summary>
        /// 某天的热门事件
        /// </summary>
        [JsonPropertyName("date")]
        public string Date { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [JsonPropertyName("tenant_id")]
        public string TenantId { get; set; }

        /// <summary>
        /// 热门事件榜单的topn数量
        /// </summary>
        [JsonPropertyName("topn_count")]
        public long TopnCount { get; set; }
    }
}
