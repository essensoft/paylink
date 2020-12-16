using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FullReductionDTO Data Structure.
    /// </summary>
    public class FullReductionDTO : AlipayObject
    {
        /// <summary>
        /// 是否仅满减商品（Y/N）
        /// </summary>
        [JsonPropertyName("full_reduction_only")]
        public string FullReductionOnly { get; set; }

        /// <summary>
        /// 满减skuId
        /// </summary>
        [JsonPropertyName("full_reduction_sku_id")]
        public List<string> FullReductionSkuId { get; set; }

        /// <summary>
        /// 最低消费，如果有阶梯规则，则用英文逗号拼接
        /// </summary>
        [JsonPropertyName("min_consumption")]
        public string MinConsumption { get; set; }

        /// <summary>
        /// 最少份数，如果有阶梯规则，则用英文逗号拼接
        /// </summary>
        [JsonPropertyName("min_nums")]
        public string MinNums { get; set; }

        /// <summary>
        /// 营销商品skuId
        /// </summary>
        [JsonPropertyName("promotion_sku_id")]
        public List<string> PromotionSkuId { get; set; }

        /// <summary>
        /// 满减金额，两位小数，如果有阶梯规则，用英文逗号分割
        /// </summary>
        [JsonPropertyName("reduction_amount")]
        public string ReductionAmount { get; set; }
    }
}
