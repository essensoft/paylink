using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PromoPageResult Data Structure.
    /// </summary>
    [Serializable]
    public class PromoPageResult : AlipayObject
    {
        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页多少条
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [JsonProperty("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 总共有多少页
        /// </summary>
        [JsonProperty("total_pages")]
        public long TotalPages { get; set; }
    }
}
