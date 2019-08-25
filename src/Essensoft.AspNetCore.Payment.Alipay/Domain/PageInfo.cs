using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PageInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PageInfo : AlipayObject
    {
        /// <summary>
        /// 分页查询当前页
        /// </summary>
        [JsonProperty("current")]
        public long Current { get; set; }

        /// <summary>
        /// 分页查询单页记录数
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 创意总数
        /// </summary>
        [JsonProperty("total")]
        public long Total { get; set; }
    }
}
