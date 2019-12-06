using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MallDiscountDetail Data Structure.
    /// </summary>
    public class MallDiscountDetail : AlipayObject
    {
        /// <summary>
        /// 优惠金额
        /// </summary>
        [JsonPropertyName("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 优惠描述，比如至多优惠XX元，满XX减XX
        /// </summary>
        [JsonPropertyName("discount_desc")]
        public List<string> DiscountDesc { get; set; }

        /// <summary>
        /// 优惠类型,外部优惠（OUT_DISCOUNT），商家优惠（M_DISCOUNT），平台优惠（RT_DISCOUNT）
        /// </summary>
        [JsonPropertyName("discount_type")]
        public string DiscountType { get; set; }

        /// <summary>
        /// 优惠ID或活动ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 优惠名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 是否是购买券, true代表是购买的券，false调表不是购买的券
        /// </summary>
        [JsonPropertyName("purchased")]
        public bool Purchased { get; set; }
    }
}
