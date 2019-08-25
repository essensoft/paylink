using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PageCreative Data Structure.
    /// </summary>
    [Serializable]
    public class PageCreative : AlipayObject
    {
        /// <summary>
        /// 创意详情列表
        /// </summary>
        [JsonProperty("list")]
        public List<CreativeDetail> List { get; set; }

        /// <summary>
        /// 创意分页信息
        /// </summary>
        [JsonProperty("pagination")]
        public PageInfo Pagination { get; set; }
    }
}
