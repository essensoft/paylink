using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BusRealtimeInfo Data Structure.
    /// </summary>
    public class BusRealtimeInfo : AlipayObject
    {
        /// <summary>
        /// 线路id，线路的唯一标志。
        /// </summary>
        [JsonPropertyName("line_id")]
        public string LineId { get; set; }

        /// <summary>
        /// 线路名称
        /// </summary>
        [JsonPropertyName("line_name")]
        public string LineName { get; set; }

        /// <summary>
        /// 剩余到站时间，单位是秒。
        /// </summary>
        [JsonPropertyName("seconds_left")]
        public long SecondsLeft { get; set; }

        /// <summary>
        /// 站点id，站点的唯一标志。
        /// </summary>
        [JsonPropertyName("station_id")]
        public string StationId { get; set; }

        /// <summary>
        /// 剩余到站站数
        /// </summary>
        [JsonPropertyName("station_left")]
        public long StationLeft { get; set; }

        /// <summary>
        /// 站点名称
        /// </summary>
        [JsonPropertyName("station_name")]
        public string StationName { get; set; }

        /// <summary>
        /// 线路运营子状态。取值如下： 0：正常，有实时数据 -1：等待发车 -2：实时信息维护中 -3：已停运 -4：尚未发车 -5：尚未开通实时公交 -8：不在运营时间
        /// </summary>
        [JsonPropertyName("sub_status")]
        public string SubStatus { get; set; }

        /// <summary>
        /// 线路运营子状态文案。例如：不在运营时间
        /// </summary>
        [JsonPropertyName("sub_text")]
        public string SubText { get; set; }
    }
}
