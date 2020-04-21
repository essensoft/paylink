using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ReportCondition Data Structure.
    /// </summary>
    public class ReportCondition : AlipayObject
    {
        /// <summary>
        /// 字段名称
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 操作符号。可能值：EQ(等于),GT(大于),LT(小于),LTE(小于或等于),GTE(大于或等于),NOT_EQ(不等于),LIKE(like),NOT_LIKE(not like),IN(in),NOT_IN(not in),BETWEEN(between)
        /// </summary>
        [JsonPropertyName("operate")]
        public string Operate { get; set; }
    }
}
