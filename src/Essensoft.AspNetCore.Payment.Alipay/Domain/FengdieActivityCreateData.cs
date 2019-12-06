using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FengdieActivityCreateData Data Structure.
    /// </summary>
    public class FengdieActivityCreateData : AlipayObject
    {
        /// <summary>
        /// H5应用的名称，用户自定义，最终用于生成URL。生成URL的规则“域名/p/f/${name}/页面名称.html”
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 用户自定义，到了该时间后，用户将访问不到该应用
        /// </summary>
        [JsonPropertyName("offline_time")]
        public string OfflineTime { get; set; }

        /// <summary>
        /// H5应用的页面在编辑器中默认展示的数据
        /// </summary>
        [JsonPropertyName("page")]
        public List<FengdieActivityCreatePageData> Page { get; set; }

        /// <summary>
        /// H5应用标题，用户自定义
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
