using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringPosDishSyncResponse.
    /// </summary>
    public class KoubeiCateringPosDishSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 菜品的ID
        /// </summary>
        [JsonPropertyName("dish_id")]
        public string DishId { get; set; }
    }
}
