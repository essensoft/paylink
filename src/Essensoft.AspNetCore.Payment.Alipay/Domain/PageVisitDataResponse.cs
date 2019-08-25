using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PageVisitDataResponse Data Structure.
    /// </summary>
    [Serializable]
    public class PageVisitDataResponse : AlipayObject
    {
        /// <summary>
        /// 页面的访问次数
        /// </summary>
        [JsonProperty("page_pv")]
        public long PagePv { get; set; }

        /// <summary>
        /// 页面的访问人数
        /// </summary>
        [JsonProperty("page_uv")]
        public long PageUv { get; set; }

        /// <summary>
        /// 小程序的页面地址
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
