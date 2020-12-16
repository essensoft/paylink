using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringKmsBakingSyncModel Data Structure.
    /// </summary>
    public class KoubeiCateringKmsBakingSyncModel : AlipayObject
    {
        /// <summary>
        /// 同步:sync; 核对:check;
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// 核对数据，如果action=check则必填
        /// </summary>
        [JsonPropertyName("check_data")]
        public KmsBakingCheckDTO CheckData { get; set; }

        /// <summary>
        /// 烘焙库存数据，根据type选填，一次最多批量同步100条数据。
        /// </summary>
        [JsonPropertyName("inventory_data")]
        public List<KmsBakingInventoryDTO> InventoryData { get; set; }

        /// <summary>
        /// 烘焙营销数据，根据type选填，一次最多批量同步100条数据。
        /// </summary>
        [JsonPropertyName("promotion_data")]
        public List<KmsBakingPromotionDTO> PromotionData { get; set; }

        /// <summary>
        /// 口碑门店Id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 库存：inventory 营销：promotion
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
