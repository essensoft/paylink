using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayUserAlipaypointBudgetlibQueryResponse.
    /// </summary>
    public class AlipayUserAlipaypointBudgetlibQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 集分宝预算库编码
        /// </summary>
        [JsonPropertyName("budget_code")]
        public string BudgetCode { get; set; }

        /// <summary>
        /// 预算库的中文描述
        /// </summary>
        [JsonPropertyName("budget_desc")]
        public string BudgetDesc { get; set; }

        /// <summary>
        /// 预算库累计积分数
        /// </summary>
        [JsonPropertyName("cumulative_amount")]
        public long CumulativeAmount { get; set; }

        /// <summary>
        /// 预算库是否为生效状态标识，true-生效中，false-已失效
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// 预算库结束时间, yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 预算库当前剩余积分数
        /// </summary>
        [JsonPropertyName("remain_amount")]
        public long RemainAmount { get; set; }

        /// <summary>
        /// 预算库开始时间, yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }
    }
}
