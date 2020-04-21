using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PortfolioShop Data Structure.
    /// </summary>
    public class PortfolioShop : AlipayObject
    {
        /// <summary>
        /// 展示权重；必须大于等于0；排序规则：权重倒叙
        /// </summary>
        [JsonPropertyName("display_weight")]
        public long DisplayWeight { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
