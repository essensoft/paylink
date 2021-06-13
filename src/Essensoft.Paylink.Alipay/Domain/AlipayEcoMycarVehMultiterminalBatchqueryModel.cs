using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarVehMultiterminalBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarVehMultiterminalBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 业务id 例: biz_scene为PARKING_SERVICE时,可传入parkingId(支付宝车场唯一id)
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务场景 PARKING_SERVICE(停车服务)
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 纬度，根据传入经纬度搜索radius内的车场
        /// </summary>
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度，根据传入经纬度搜索radius内的车场
        /// </summary>
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 分页页码,从1开始
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小，上限200条
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 距离[单位：米]，上限10公里
        /// </summary>
        [JsonPropertyName("radius")]
        public long Radius { get; set; }
    }
}
