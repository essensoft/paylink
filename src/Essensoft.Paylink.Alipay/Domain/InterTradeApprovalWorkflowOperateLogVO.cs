using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// InterTradeApprovalWorkflowOperateLogVO Data Structure.
    /// </summary>
    public class InterTradeApprovalWorkflowOperateLogVO : AlipayObject
    {
        /// <summary>
        /// 节点业务类型
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 操作备注
        /// </summary>
        [JsonPropertyName("operate_memo")]
        public string OperateMemo { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [JsonPropertyName("operate_type_name")]
        public string OperateTypeName { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        [JsonPropertyName("operator_time")]
        public string OperatorTime { get; set; }
    }
}
