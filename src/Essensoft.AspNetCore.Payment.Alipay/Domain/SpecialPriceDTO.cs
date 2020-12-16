using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SpecialPriceDTO Data Structure.
    /// </summary>
    public class SpecialPriceDTO : AlipayObject
    {
        /// <summary>
        /// 最少份数，如果有阶梯规则，多个值用英文逗号分割，例如：3,5
        /// </summary>
        [JsonPropertyName("min_nums")]
        public string MinNums { get; set; }

        /// <summary>
        /// 营销活动skuid
        /// </summary>
        [JsonPropertyName("promotion_sku_id")]
        public List<string> PromotionSkuId { get; set; }

        /// <summary>
        /// 活动价，必须是数字格式，且最多两位小数点。 如果有阶梯规则，多个值用英文逗号分割，例如：10,5
        /// </summary>
        [JsonPropertyName("special_price")]
        public string SpecialPrice { get; set; }

        /// <summary>
        /// 是否仅特价商品（Y/N）
        /// </summary>
        [JsonPropertyName("special_price_only")]
        public string SpecialPriceOnly { get; set; }

        /// <summary>
        /// 特价skuId
        /// </summary>
        [JsonPropertyName("special_price_sku_id")]
        public List<string> SpecialPriceSkuId { get; set; }
    }
}
