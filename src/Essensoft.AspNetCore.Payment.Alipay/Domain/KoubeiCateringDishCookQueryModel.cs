using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringDishCookQueryModel Data Structure.
    /// </summary>
    public class KoubeiCateringDishCookQueryModel : AlipayObject
    {
        /// <summary>
        /// 菜谱id
        /// </summary>
        [JsonPropertyName("cook_id")]
        public string CookId { get; set; }

        /// <summary>
        /// 菜谱状态
        /// </summary>
        [JsonPropertyName("cook_status")]
        public string CookStatus { get; set; }

        /// <summary>
        /// 菜谱中菜品的分类id
        /// </summary>
        [JsonPropertyName("detail_catetory_big_id")]
        public string DetailCatetoryBigId { get; set; }

        /// <summary>
        /// 菜谱中菜品分类小类id
        /// </summary>
        [JsonPropertyName("detail_catetory_small_id")]
        public string DetailCatetorySmallId { get; set; }

        /// <summary>
        /// 菜谱中菜品的状态
        /// </summary>
        [JsonPropertyName("detail_status")]
        public string DetailStatus { get; set; }

        /// <summary>
        /// 菜品id
        /// </summary>
        [JsonPropertyName("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 商户的支付宝user_id. 商户授权后,isv能获得
        /// </summary>
        [JsonPropertyName("merchant_id")]
        public string MerchantId { get; set; }
    }
}
