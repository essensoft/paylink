using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusScheduletaskshiftAddModel Data Structure.
    /// </summary>
    public class AlipayDataAiserviceCloudbusScheduletaskshiftAddModel : AlipayObject
    {
        /// <summary>
        /// 接口版本号
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 公交公司id
        /// </summary>
        [JsonPropertyName("corp_id")]
        public string CorpId { get; set; }

        /// <summary>
        /// 待轮班的日期天数
        /// </summary>
        [JsonPropertyName("cycle_cnt")]
        public long CycleCnt { get; set; }

        /// <summary>
        /// 该线路配备的司机数
        /// </summary>
        [JsonPropertyName("driver_cnt")]
        public long DriverCnt { get; set; }

        /// <summary>
        /// 拓展参数
        /// </summary>
        [JsonPropertyName("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 线路id
        /// </summary>
        [JsonPropertyName("line_id")]
        public string LineId { get; set; }

        /// <summary>
        /// 待排班的时期列表，多个用逗号分隔
        /// </summary>
        [JsonPropertyName("shift_date_list")]
        public List<string> ShiftDateList { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonPropertyName("task_name")]
        public string TaskName { get; set; }

        /// <summary>
        /// 排班任务id
        /// </summary>
        [JsonPropertyName("work_schedule_pids")]
        public List<string> WorkSchedulePids { get; set; }
    }
}
