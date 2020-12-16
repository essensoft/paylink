using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StationLine Data Structure.
    /// </summary>
    public class StationLine : AlipayObject
    {
        /// <summary>
        /// 实时公交到站信息
        /// </summary>
        [JsonPropertyName("buses")]
        public BusRealtimeInfo Buses { get; set; }

        /// <summary>
        /// 终点站
        /// </summary>
        [JsonPropertyName("end_stop")]
        public string EndStop { get; set; }

        /// <summary>
        /// 首班车时间。格式为HH:MM
        /// </summary>
        [JsonPropertyName("first_bus")]
        public string FirstBus { get; set; }

        /// <summary>
        /// 发车间隔。单位是分钟
        /// </summary>
        [JsonPropertyName("interval")]
        public long Interval { get; set; }

        /// <summary>
        /// 末班车时间。格式为HH:MM
        /// </summary>
        [JsonPropertyName("last_bus")]
        public string LastBus { get; set; }

        /// <summary>
        /// 详情详情跳转链接。支付宝小程序内部可以跳转到这个链接对应的页面
        /// </summary>
        [JsonPropertyName("line_detail_schema")]
        public string LineDetailSchema { get; set; }

        /// <summary>
        /// 线路id
        /// </summary>
        [JsonPropertyName("line_id")]
        public string LineId { get; set; }

        /// <summary>
        /// 线路名称
        /// </summary>
        [JsonPropertyName("line_name")]
        public string LineName { get; set; }

        /// <summary>
        /// 是否支持实时公交到站信息。true支持，false 不支持
        /// </summary>
        [JsonPropertyName("real_time")]
        public bool RealTime { get; set; }

        /// <summary>
        /// 起点站
        /// </summary>
        [JsonPropertyName("start_stop")]
        public string StartStop { get; set; }

        /// <summary>
        /// 站点id，站点的唯一标志
        /// </summary>
        [JsonPropertyName("station_id")]
        public string StationId { get; set; }

        /// <summary>
        /// 站点名称
        /// </summary>
        [JsonPropertyName("station_name")]
        public string StationName { get; set; }
    }
}
