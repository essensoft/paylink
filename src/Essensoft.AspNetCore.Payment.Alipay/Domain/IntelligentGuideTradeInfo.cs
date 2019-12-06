using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IntelligentGuideTradeInfo Data Structure.
    /// </summary>
    public class IntelligentGuideTradeInfo : AlipayObject
    {
        /// <summary>
        /// 商户在口碑侧的门店id，校验纯数字，28位
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 商户门店名称
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 单个门店下的具体交易信息列表
        /// </summary>
        [JsonPropertyName("trade_details")]
        public List<IntelligentGuideTradeDetail> TradeDetails { get; set; }
    }
}
