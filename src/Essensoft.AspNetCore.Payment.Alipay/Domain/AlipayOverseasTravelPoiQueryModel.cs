using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasTravelPoiQueryModel Data Structure.
    /// </summary>
    public class AlipayOverseasTravelPoiQueryModel : AlipayObject
    {
        /// <summary>
        /// 店铺id
        /// </summary>
        [JsonPropertyName("global_shop_id")]
        public string GlobalShopId { get; set; }

        /// <summary>
        /// 飞猪poiId
        /// </summary>
        [JsonPropertyName("poi_id")]
        public string PoiId { get; set; }

        /// <summary>
        /// 回传同步POI信息扩展字段中的poi_task_sub_type
        /// </summary>
        [JsonPropertyName("poi_task_sub_type")]
        public string PoiTaskSubType { get; set; }
    }
}
