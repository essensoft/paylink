using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FengdieSitesPageModel Data Structure.
    /// </summary>
    [Serializable]
    public class FengdieSitesPageModel : AlipayObject
    {
        /// <summary>
        /// 站点页面别名
        /// </summary>
        [JsonProperty("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// 是否为首页
        /// </summary>
        [JsonProperty("is_home_page")]
        public bool IsHomePage { get; set; }

        /// <summary>
        /// 首页原始 url，仅在 isHomePage = true 时候才存在
        /// </summary>
        [JsonProperty("origin_url")]
        public string OriginUrl { get; set; }

        /// <summary>
        /// 活动页面 schema 数据
        /// </summary>
        [JsonProperty("schema")]
        public List<FengdieActivitySchemaModel> Schema { get; set; }

        /// <summary>
        /// H5页面预览图
        /// </summary>
        [JsonProperty("snapshot")]
        public string Snapshot { get; set; }

        /// <summary>
        /// 页面访问地址
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
