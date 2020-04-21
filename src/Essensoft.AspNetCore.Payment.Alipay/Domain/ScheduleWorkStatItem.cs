using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ScheduleWorkStatItem Data Structure.
    /// </summary>
    public class ScheduleWorkStatItem : AlipayObject
    {
        /// <summary>
        /// 总里程统计指标 {sum:2500,mean:130,max:180,min:60,std:40.2}
        /// </summary>
        [JsonPropertyName("all_miles_sts")]
        public string AllMilesSts { get; set; }

        /// <summary>
        /// 总车次数统计指标 {sum:250,mean:13,max:18,min:6,std:4.02}
        /// </summary>
        [JsonPropertyName("all_trip_sts")]
        public string AllTripSts { get; set; }

        /// <summary>
        /// 下行总班次数
        /// </summary>
        [JsonPropertyName("down_chain_cnt")]
        public long DownChainCnt { get; set; }

        /// <summary>
        /// 非营运里程统计指标 {“1”:220,“2”:50,“3”:120,“4”:50,”5”:0} Key为排班计划中的发车类型
        /// </summary>
        [JsonPropertyName("invalid_miles_sts")]
        public string InvalidMilesSts { get; set; }

        /// <summary>
        /// 非营运车次数统计指标 {“1”:22,“2”:5,“3”:12,“4”:5,”5”:0} Key为排班计划中的发车类型
        /// </summary>
        [JsonPropertyName("invalid_trip_sts")]
        public string InvalidTripSts { get; set; }

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
        /// 上行总班次数
        /// </summary>
        [JsonPropertyName("up_chain_cnt")]
        public long UpChainCnt { get; set; }

        /// <summary>
        /// 营运里程统计指标 {sum:2300,mean:110,max:150,min:40,std:30.2}
        /// </summary>
        [JsonPropertyName("valid_miles_sts")]
        public string ValidMilesSts { get; set; }

        /// <summary>
        /// 营运车次数统计指标 {sum:230,mean:11,max:15,min:4,std:3.02}
        /// </summary>
        [JsonPropertyName("valid_trip_sts")]
        public string ValidTripSts { get; set; }

        /// <summary>
        /// 等待时长统计指标(Json) {sum:55:10:00,mean:02:10:00,max:06:10:00,min:00:50:00,std:01:01:00}'
        /// </summary>
        [JsonPropertyName("wait_time_sts")]
        public string WaitTimeSts { get; set; }

        /// <summary>
        /// 工作时长统计指标(Json) {sum:246:03:00,mean:10:10:00,max:17:10:00,min:06:50:00,std:02:01:00}
        /// </summary>
        [JsonPropertyName("work_time_sts")]
        public string WorkTimeSts { get; set; }
    }
}
