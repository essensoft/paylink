using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasTravelFliggyPoiCreateModel Data Structure.
    /// </summary>
    public class AlipayOverseasTravelFliggyPoiCreateModel : AlipayObject
    {
        /// <summary>
        /// 同步数据版本
        /// </summary>
        [JsonPropertyName("data_version")]
        public string DataVersion { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [JsonPropertyName("global_shop_id")]
        public string GlobalShopId { get; set; }

        /// <summary>
        /// 飞猪POI ID
        /// </summary>
        [JsonPropertyName("poi_data")]
        public FliggyPoiInfo PoiData { get; set; }

        /// <summary>
        /// 外部请求ID,做幂等
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 支付宝端子任务类型，需回传
        /// </summary>
        [JsonPropertyName("task_subtype")]
        public string TaskSubtype { get; set; }
    }
}
