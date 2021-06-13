using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// VehSearchItem Data Structure.
    /// </summary>
    public class VehSearchItem : AlipayObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 业务id 例:biz_scene为PARKING_SERVICE时,biz_id为支付宝唯一车场id
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务场景 暂只支持PARKING_SERVICE(附近停车场)
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 距离，单位为米
        /// </summary>
        [JsonPropertyName("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 高德地图的poiid
        /// </summary>
        [JsonPropertyName("poi_id")]
        public string PoiId { get; set; }

        /// <summary>
        /// 支持服务列表
        /// </summary>
        [JsonPropertyName("support_service_list")]
        public List<VehServiceItem> SupportServiceList { get; set; }
    }
}
