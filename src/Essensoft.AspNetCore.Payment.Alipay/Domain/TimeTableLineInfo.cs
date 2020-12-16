using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TimeTableLineInfo Data Structure.
    /// </summary>
    public class TimeTableLineInfo : AlipayObject
    {
        /// <summary>
        /// 自定义发车间隔列表，在指定时间区间内覆盖全局配置
        /// </summary>
        [JsonPropertyName("customized_time_interval_list")]
        public List<TimeInterval> CustomizedTimeIntervalList { get; set; }

        /// <summary>
        /// 线路方向（UP-上行，DOWN-下行）
        /// </summary>
        [JsonPropertyName("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 期望车次总数
        /// </summary>
        [JsonPropertyName("expect_trip_count")]
        public long ExpectTripCount { get; set; }

        /// <summary>
        /// 扩展参数，json格式，由双方约定取值
        /// </summary>
        [JsonPropertyName("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 线路ID，同一条线路的不同方向该值不同
        /// </summary>
        [JsonPropertyName("line_id")]
        public string LineId { get; set; }

        /// <summary>
        /// 线路Key，同一条线路的不同方向该值相同
        /// </summary>
        [JsonPropertyName("line_key")]
        public string LineKey { get; set; }

        /// <summary>
        /// 全局最大发车间隔，单位：分钟
        /// </summary>
        [JsonPropertyName("max_time_interval")]
        public long MaxTimeInterval { get; set; }

        /// <summary>
        /// 全局最小发车间隔，单位：分钟
        /// </summary>
        [JsonPropertyName("min_time_interval")]
        public long MinTimeInterval { get; set; }

        /// <summary>
        /// 运营结束时间（hh24:mi:ss）
        /// </summary>
        [JsonPropertyName("service_end_time")]
        public string ServiceEndTime { get; set; }

        /// <summary>
        /// 运营起始时间（hh24:mi:ss）
        /// </summary>
        [JsonPropertyName("service_start_time")]
        public string ServiceStartTime { get; set; }

        /// <summary>
        /// 聚合时间粒度，单位：分钟，只支持30/60。如无需执行客流分析可不传
        /// </summary>
        [JsonPropertyName("time_span")]
        public long TimeSpan { get; set; }

        /// <summary>
        /// 单车容量
        /// </summary>
        [JsonPropertyName("vehicle_capacity")]
        public long VehicleCapacity { get; set; }
    }
}
