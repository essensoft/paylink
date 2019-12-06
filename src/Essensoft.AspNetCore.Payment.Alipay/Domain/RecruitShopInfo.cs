using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RecruitShopInfo Data Structure.
    /// </summary>
    public class RecruitShopInfo : AlipayObject
    {
        /// <summary>
        /// 已确认还是未确认
        /// </summary>
        [JsonPropertyName("confirm_status")]
        public string ConfirmStatus { get; set; }

        /// <summary>
        /// 一级和二级类目名称
        /// </summary>
        [JsonPropertyName("shop_category")]
        public string ShopCategory { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }
    }
}
