using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiDiscountBillQueryModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiDiscountBillQueryModel : AlipayObject
    {
        /// <summary>
        /// 账单创建结束时间，与开始时间相距不能超过一个月
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// solution_id，贴息方案实例id
        /// </summary>
        [JsonPropertyName("solution_id")]
        public string SolutionId { get; set; }

        /// <summary>
        /// 账单创建起始时间
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }
    }
}
