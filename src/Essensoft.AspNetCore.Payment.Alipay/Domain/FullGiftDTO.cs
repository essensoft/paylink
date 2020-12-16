using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FullGiftDTO Data Structure.
    /// </summary>
    public class FullGiftDTO : AlipayObject
    {
        /// <summary>
        /// 赠送金额，如果有阶梯规则，多个值用英文逗号分割，例如：10,20
        /// </summary>
        [JsonPropertyName("gift_amount")]
        public string GiftAmount { get; set; }

        /// <summary>
        /// 赠送最低消费，如果有阶梯规则，多个值用英文逗号分割，例如：10,20
        /// </summary>
        [JsonPropertyName("gift_min_consumption")]
        public string GiftMinConsumption { get; set; }

        /// <summary>
        /// 赠送份数，如果有阶梯规则，多个值用英文逗号分割，例如：1,2
        /// </summary>
        [JsonPropertyName("gift_nums")]
        public string GiftNums { get; set; }

        /// <summary>
        /// 满赠skuid
        /// </summary>
        [JsonPropertyName("gift_sku_id")]
        public List<string> GiftSkuId { get; set; }

        /// <summary>
        /// 最低消费，如果有阶梯规则，多个值用英文逗号分割，例如：1,2
        /// </summary>
        [JsonPropertyName("min_consumption")]
        public string MinConsumption { get; set; }

        /// <summary>
        /// 最少份数，如果有阶梯规则，多个值用英文逗号分割，例如：1,2
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
