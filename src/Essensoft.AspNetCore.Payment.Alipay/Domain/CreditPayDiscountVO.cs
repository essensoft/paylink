using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CreditPayDiscountVO Data Structure.
    /// </summary>
    public class CreditPayDiscountVO : AlipayObject
    {
        /// <summary>
        /// 折扣描述
        /// </summary>
        [JsonPropertyName("discount_desc")]
        public string DiscountDesc { get; set; }

        /// <summary>
        /// 折扣名
        /// </summary>
        [JsonPropertyName("discount_name")]
        public string DiscountName { get; set; }

        /// <summary>
        /// 整体折扣利率，仅在均匀打折下生效，小数形式
        /// </summary>
        [JsonPropertyName("full_discount_rate")]
        public string FullDiscountRate { get; set; }

        /// <summary>
        /// 是否有营销
        /// </summary>
        [JsonPropertyName("has_discount")]
        public bool HasDiscount { get; set; }

        /// <summary>
        /// 是否是非均匀打折，true-非均匀打折，false-均匀打折
        /// </summary>
        [JsonPropertyName("is_uneven_discount")]
        public bool IsUnevenDiscount { get; set; }
    }
}
