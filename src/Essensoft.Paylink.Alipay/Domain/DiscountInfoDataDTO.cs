using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// DiscountInfoDataDTO Data Structure.
    /// </summary>
    public class DiscountInfoDataDTO : AlipayObject
    {
        /// <summary>
        /// 优惠金额
        /// </summary>
        [JsonPropertyName("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 优惠名称
        /// </summary>
        [JsonPropertyName("discount_name")]
        public string DiscountName { get; set; }

        /// <summary>
        /// 优惠跳转链接地址
        /// </summary>
        [JsonPropertyName("discount_page_link")]
        public string DiscountPageLink { get; set; }

        /// <summary>
        /// 优惠数量
        /// </summary>
        [JsonPropertyName("discount_quantity")]
        public long DiscountQuantity { get; set; }

        /// <summary>
        /// 外部优惠id
        /// </summary>
        [JsonPropertyName("external_discount_id")]
        public string ExternalDiscountId { get; set; }
    }
}
