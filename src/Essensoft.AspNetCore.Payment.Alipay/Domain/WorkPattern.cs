using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// WorkPattern Data Structure.
    /// </summary>
    public class WorkPattern : AlipayObject
    {
        /// <summary>
        /// 线路方向
        /// </summary>
        [JsonPropertyName("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 扩展参数，json格式，由双方约定取值
        /// </summary>
        [JsonPropertyName("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 最大工作时长，单位：小时
        /// </summary>
        [JsonPropertyName("max_work_time")]
        public string MaxWorkTime { get; set; }

        /// <summary>
        /// 使用该班型的班次数量
        /// </summary>
        [JsonPropertyName("work_count")]
        public long WorkCount { get; set; }

        /// <summary>
        /// 班型明细列表
        /// </summary>
        [JsonPropertyName("work_pattern_detail_list")]
        public List<WorkPatternDetail> WorkPatternDetailList { get; set; }

        /// <summary>
        /// 班型编号
        /// </summary>
        [JsonPropertyName("work_pattern_id")]
        public string WorkPatternId { get; set; }
    }
}
