using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ScheduleWorkItem Data Structure.
    /// </summary>
    public class ScheduleWorkItem : AlipayObject
    {
        /// <summary>
        /// 该班次总里程
        /// </summary>
        [JsonPropertyName("all_miles")]
        public long AllMiles { get; set; }

        /// <summary>
        /// 该班次总车次数
        /// </summary>
        [JsonPropertyName("all_trip_cnt")]
        public long AllTripCnt { get; set; }

        /// <summary>
        /// 班次序号
        /// </summary>
        [JsonPropertyName("chain_num")]
        public long ChainNum { get; set; }

        /// <summary>
        /// 该班次非营运里程
        /// </summary>
        [JsonPropertyName("invalid_miles")]
        public long InvalidMiles { get; set; }

        /// <summary>
        /// 该班次非营运车次数
        /// </summary>
        [JsonPropertyName("invalid_trip_cnt")]
        public long InvalidTripCnt { get; set; }

        /// <summary>
        /// 线路id
        /// </summary>
        [JsonPropertyName("line_id")]
        public string LineId { get; set; }

        /// <summary>
        /// 优化目标，0：班次最少；1：工作时长最短；2：等待时间最少；3：工作时长最均匀
        /// </summary>
        [JsonPropertyName("opt_type")]
        public long OptType { get; set; }

        /// <summary>
        /// 班制编号（0：通班；1：双班，2：三班）
        /// </summary>
        [JsonPropertyName("shift_id")]
        public string ShiftId { get; set; }

        /// <summary>
        /// 车次链信息（json格式）
        /// </summary>
        [JsonPropertyName("trip_chain")]
        public string TripChain { get; set; }

        /// <summary>
        /// 该班次营运里程
        /// </summary>
        [JsonPropertyName("valid_miles")]
        public long ValidMiles { get; set; }

        /// <summary>
        /// 该班次营运车次数
        /// </summary>
        [JsonPropertyName("valid_trip_cnt")]
        public long ValidTripCnt { get; set; }

        /// <summary>
        /// 等待时长 02:10:00
        /// </summary>
        [JsonPropertyName("wait_time")]
        public string WaitTime { get; set; }

        /// <summary>
        /// 工作结束时间，如20:30:00
        /// </summary>
        [JsonPropertyName("work_endtime")]
        public string WorkEndtime { get; set; }

        /// <summary>
        /// 班型编号（0：全天班；1：上午班，2：下午班，3：夜班）
        /// </summary>
        [JsonPropertyName("work_id")]
        public string WorkId { get; set; }

        /// <summary>
        /// 工作开始时间，如10:00:00
        /// </summary>
        [JsonPropertyName("work_starttime")]
        public string WorkStarttime { get; set; }

        /// <summary>
        /// 工作时长，如15:10:00
        /// </summary>
        [JsonPropertyName("work_time")]
        public string WorkTime { get; set; }
    }
}
