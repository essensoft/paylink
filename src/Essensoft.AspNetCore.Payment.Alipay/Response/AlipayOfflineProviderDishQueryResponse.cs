using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOfflineProviderDishQueryResponse.
    /// </summary>
    public class AlipayOfflineProviderDishQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 总共有多少条菜品信息。可用于计算分页。
        /// </summary>
        [JsonProperty("items")]
        public long Items { get; set; }

        /// <summary>
        /// 菜品列表信息
        /// </summary>
        [JsonProperty("list")]
        public List<IsvShopDishModel> List { get; set; }

        /// <summary>
        /// 当前数据所在的页码数
        /// </summary>
        [JsonProperty("page")]
        public long Page { get; set; }

        /// <summary>
        /// 当前查询结果分页的条数，可用于计算分页
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 当前条件下查询结果总的页码数
        /// </summary>
        [JsonProperty("pages")]
        public long Pages { get; set; }
    }
}
