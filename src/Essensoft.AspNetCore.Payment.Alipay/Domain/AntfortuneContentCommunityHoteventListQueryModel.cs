using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntfortuneContentCommunityHoteventListQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneContentCommunityHoteventListQueryModel : AlipayObject
    {
        /// <summary>
        /// 某天的热门事件
        /// </summary>
        [JsonProperty("date")]
        public string Date { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [JsonProperty("tenant_id")]
        public string TenantId { get; set; }

        /// <summary>
        /// 热门事件榜单的topn数量
        /// </summary>
        [JsonProperty("topn_count")]
        public long TopnCount { get; set; }
    }
}
