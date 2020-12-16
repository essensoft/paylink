using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityRopgnRisktaskCreateModel Data Structure.
    /// </summary>
    public class AlipaySecurityRopgnRisktaskCreateModel : AlipayObject
    {
        /// <summary>
        /// 任务扩展信息
        /// </summary>
        [JsonPropertyName("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 业务系统流水号
        /// </summary>
        [JsonPropertyName("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 任务来源
        /// </summary>
        [JsonPropertyName("task_source")]
        public string TaskSource { get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        [JsonPropertyName("task_type")]
        public string TaskType { get; set; }

        /// <summary>
        /// 租户，目前只有ALIPW3CN这一个租户
        /// </summary>
        [JsonPropertyName("tenant")]
        public string Tenant { get; set; }
    }
}
