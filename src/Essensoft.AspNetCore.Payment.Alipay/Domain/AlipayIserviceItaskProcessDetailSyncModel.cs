using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceItaskProcessDetailSyncModel Data Structure.
    /// </summary>
    public class AlipayIserviceItaskProcessDetailSyncModel : AlipayObject
    {
        /// <summary>
        /// 需要同步的蚂蚁域内的具体工单平台
        /// </summary>
        [JsonPropertyName("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 接口客户端名称
        /// </summary>
        [JsonPropertyName("exapp_name")]
        public string ExappName { get; set; }

        /// <summary>
        /// 外部系统工单处理同学id
        /// </summary>
        [JsonPropertyName("exsystem_operator_id")]
        public string ExsystemOperatorId { get; set; }

        /// <summary>
        /// 外部系统对工单进行处理的人员名称
        /// </summary>
        [JsonPropertyName("exsystem_operator_name")]
        public string ExsystemOperatorName { get; set; }

        /// <summary>
        /// 外部系统的工单id
        /// </summary>
        [JsonPropertyName("exsystem_ticket_id")]
        public string ExsystemTicketId { get; set; }

        /// <summary>
        /// 外部系统的工单状态，枚举值，目前只有一个值: COMPLETED。  如果传空，默认为 COMPLETED 。
        /// </summary>
        [JsonPropertyName("exsystem_ticket_state")]
        public string ExsystemTicketState { get; set; }

        /// <summary>
        /// 外部工单业务扩展字段列表，业务属性信息都放置在此字段。
        /// </summary>
        [JsonPropertyName("extend_field_infos")]
        public List<ExtendFieldInfo> ExtendFieldInfos { get; set; }
    }
}
