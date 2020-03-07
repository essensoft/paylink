using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandAssetdeliveryAssignQueryResponse.
    /// </summary>
    public class AntMerchantExpandAssetdeliveryAssignQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 配送指令集合
        /// </summary>
        [JsonPropertyName("asset_delivery_items")]
        public List<AssetDeliveryItem> AssetDeliveryItems { get; set; }

        /// <summary>
        /// 当前是否还有配送指令可以拉取; 注意如果该值为false, 也只是提示当前时刻没有更多配送指令了, 不代表后面没有配送指令, 商户需要自己制定策略定时去拉取.
        /// </summary>
        [JsonPropertyName("has_next_page")]
        public bool HasNextPage { get; set; }
    }
}
