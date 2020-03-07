using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandAssetproduceAssignQueryResponse.
    /// </summary>
    public class AntMerchantExpandAssetproduceAssignQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 生产指令集合, 订单明细ID(assign_item_id)为唯一键值.
        /// </summary>
        [JsonPropertyName("asset_produce_items")]
        public List<AssetProduceItem> AssetProduceItems { get; set; }

        /// <summary>
        /// 当前是否还有生产指令可以拉取; 注意如果该值为false, 也只是提示当前没有更多生产指令了, 不代表后面没有生产指令, 商户需要自己制定策略定时去拉取.
        /// </summary>
        [JsonPropertyName("has_next_page")]
        public bool HasNextPage { get; set; }
    }
}
