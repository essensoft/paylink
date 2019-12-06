using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosMaterialModifyModel Data Structure.
    /// </summary>
    public class KoubeiCateringPosMaterialModifyModel : AlipayObject
    {
        /// <summary>
        /// 配料id
        /// </summary>
        [JsonPropertyName("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 配料名称
        /// </summary>
        [JsonPropertyName("material_name")]
        public string MaterialName { get; set; }

        /// <summary>
        /// 售价
        /// </summary>
        [JsonPropertyName("sell_price")]
        public string SellPrice { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
