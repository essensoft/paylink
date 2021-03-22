using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// JourneyLocation Data Structure.
    /// </summary>
    public class JourneyLocation : AlipayObject
    {
        /// <summary>
        /// 支付宝域内aoiId
        /// </summary>
        [JsonPropertyName("aoi_id")]
        public string AoiId { get; set; }

        /// <summary>
        /// 城市名
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public List<OrderExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 支付宝侧地点id
        /// </summary>
        [JsonPropertyName("location_id")]
        public string LocationId { get; set; }

        /// <summary>
        /// 地点id类型
        /// </summary>
        [JsonPropertyName("location_id_type")]
        public string LocationIdType { get; set; }

        /// <summary>
        /// 商户侧行政区划代码
        /// </summary>
        [JsonPropertyName("merchant_division_id")]
        public string MerchantDivisionId { get; set; }

        /// <summary>
        /// (废弃)商户侧地点id
        /// </summary>
        [JsonPropertyName("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商户侧poi信息
        /// </summary>
        [JsonPropertyName("merchant_poi")]
        public string MerchantPoi { get; set; }

        /// <summary>
        /// 地点名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 支付宝域内poiId
        /// </summary>
        [JsonPropertyName("poi_id")]
        public string PoiId { get; set; }
    }
}
