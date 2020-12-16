using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringDishCreatedishSyncResponse.
    /// </summary>
    public class KoubeiCateringDishCreatedishSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 口碑菜品id
        /// </summary>
        [JsonPropertyName("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 是否需要重试
        /// </summary>
        [JsonPropertyName("retry")]
        public bool Retry { get; set; }
    }
}
