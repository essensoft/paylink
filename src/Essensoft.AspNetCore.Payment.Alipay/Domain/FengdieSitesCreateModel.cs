using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FengdieSitesCreateModel Data Structure.
    /// </summary>
    public class FengdieSitesCreateModel : AlipayObject
    {
        /// <summary>
        /// 站点域名，默认为空间中第一个可用域名
        /// </summary>
        [JsonPropertyName("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// 站点名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 站点过期时间，默认为发布时间 + 3 个月（调用站点发布接口时候可以再次修改）
        /// </summary>
        [JsonPropertyName("offline_time")]
        public string OfflineTime { get; set; }

        /// <summary>
        /// 站点页面在编辑器中默认展示的数据(废弃，请使用pages)
        /// </summary>
        [JsonPropertyName("page")]
        public FengdieActivityCreatePageData Page { get; set; }

        /// <summary>
        /// 站点页面在编辑器中默认展示的数据
        /// </summary>
        [JsonPropertyName("pages")]
        public List<FengdieActivityCreatePagesData> Pages { get; set; }

        /// <summary>
        /// 站点标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
