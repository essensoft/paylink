using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiServindustryPromoIntelligentguideOrderModel Data Structure.
    /// </summary>
    public class KoubeiServindustryPromoIntelligentguideOrderModel : AlipayObject
    {
        /// <summary>
        /// 枚举类型，目前仅支持半年(HALF_YEAR)和一年(ONE_YEAR)，使用前先确认是否有相对应的份额
        /// </summary>
        [JsonPropertyName("range_type")]
        public string RangeType { get; set; }

        /// <summary>
        /// 口碑侧门店shopId
        /// </summary>
        [JsonPropertyName("shop_id")]
        public List<string> ShopId { get; set; }
    }
}
