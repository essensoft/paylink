using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FullDiscountDTO Data Structure.
    /// </summary>
    public class FullDiscountDTO : AlipayObject
    {
        /// <summary>
        /// 折扣，如果有阶梯规则，则用英文逗号分隔
        /// </summary>
        [JsonPropertyName("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// 是否仅满折商品（Y/N）
        /// </summary>
        [JsonPropertyName("full_discount_only")]
        public string FullDiscountOnly { get; set; }

        /// <summary>
        /// 满折skuId
        /// </summary>
        [JsonPropertyName("full_discount_sku_id")]
        public List<string> FullDiscountSkuId { get; set; }

        /// <summary>
        /// 最低消费，如果有阶梯规则，则用英文逗号分隔
        /// </summary>
        [JsonPropertyName("min_consumption")]
        public string MinConsumption { get; set; }

        /// <summary>
        /// 最少份数，如果有阶梯规则，则用英文逗号拼接
        /// </summary>
        [JsonPropertyName("min_nums")]
        public string MinNums { get; set; }

        /// <summary>
        /// 营销skuId
        /// </summary>
        [JsonPropertyName("promotion_sku_id")]
        public List<string> PromotionSkuId { get; set; }
    }
}
