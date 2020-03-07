using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ScheduleShiftItem Data Structure.
    /// </summary>
    public class ScheduleShiftItem : AlipayObject
    {
        /// <summary>
        /// 班次序号（可关联排班表得到具体工作计划，0表示休息）
        /// </summary>
        [JsonPropertyName("chain_num")]
        public long ChainNum { get; set; }

        /// <summary>
        /// 轮班周期内的第几天
        /// </summary>
        [JsonPropertyName("day_num")]
        public long DayNum { get; set; }

        /// <summary>
        /// 线路id
        /// </summary>
        [JsonPropertyName("line_id")]
        public string LineId { get; set; }

        /// <summary>
        /// 虚拟员工编号
        /// </summary>
        [JsonPropertyName("vir_employ_id")]
        public string VirEmployId { get; set; }
    }
}
