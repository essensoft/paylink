using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// BPOpenApiTicketOperateTrace Data Structure.
    /// </summary>
    public class BPOpenApiTicketOperateTrace : AlipayObject
    {
        /// <summary>
        /// 所做的操作
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// 业务系统
        /// </summary>
        [JsonPropertyName("biz_app")]
        public string BizApp { get; set; }

        /// <summary>
        /// 业务id
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 处理节点显示名称
        /// </summary>
        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 处理节点名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 下一步处理节点显示名称
        /// </summary>
        [JsonPropertyName("next_display_name")]
        public string NextDisplayName { get; set; }

        /// <summary>
        /// 下一步处理节点
        /// </summary>
        [JsonPropertyName("next_name")]
        public string NextName { get; set; }

        /// <summary>
        /// 节点停留时长
        /// </summary>
        [JsonPropertyName("node_duration")]
        public long NodeDuration { get; set; }

        /// <summary>
        /// 操作名称
        /// </summary>
        [JsonPropertyName("operate")]
        public string Operate { get; set; }

        /// <summary>
        /// 节点处理时长
        /// </summary>
        [JsonPropertyName("operate_duration")]
        public long OperateDuration { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        [JsonPropertyName("operate_time")]
        public string OperateTime { get; set; }

        /// <summary>
        /// 操作者用户域名
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 操作者花名
        /// </summary>
        [JsonPropertyName("operator_name")]
        public string OperatorName { get; set; }

        /// <summary>
        /// 原处理人域名
        /// </summary>
        [JsonPropertyName("origin_operator")]
        public string OriginOperator { get; set; }

        /// <summary>
        /// 原处理人花名
        /// </summary>
        [JsonPropertyName("origin_operator_name")]
        public string OriginOperatorName { get; set; }

        /// <summary>
        /// 工单id
        /// </summary>
        [JsonPropertyName("ticket_id")]
        public string TicketId { get; set; }
    }
}
