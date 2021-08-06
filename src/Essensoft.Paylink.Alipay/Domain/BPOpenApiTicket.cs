using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// BPOpenApiTicket Data Structure.
    /// </summary>
    public class BPOpenApiTicket : AlipayObject
    {
        /// <summary>
        /// 附件
        /// </summary>
        [JsonPropertyName("attachment")]
        public string Attachment { get; set; }

        /// <summary>
        /// 来自于哪个系统
        /// </summary>
        [JsonPropertyName("biz_app")]
        public string BizApp { get; set; }

        /// <summary>
        /// 业务ID, 若来自fcprocess系统，则为pcs_process_instance_id
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务上下文
        /// </summary>
        [JsonPropertyName("business_context")]
        public string BusinessContext { get; set; }

        /// <summary>
        /// 变更版本号
        /// </summary>
        [JsonPropertyName("change_version")]
        public long ChangeVersion { get; set; }

        /// <summary>
        /// 配置ID
        /// </summary>
        [JsonPropertyName("config_id")]
        public string ConfigId { get; set; }

        /// <summary>
        /// 创建人用户域名
        /// </summary>
        [JsonPropertyName("create_operator")]
        public string CreateOperator { get; set; }

        /// <summary>
        /// 创建者名称
        /// </summary>
        [JsonPropertyName("create_operator_name")]
        public string CreateOperatorName { get; set; }

        /// <summary>
        /// 工单处理链接地址
        /// </summary>
        [JsonPropertyName("deal_url")]
        public string DealUrl { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 工单内嵌详情地址
        /// </summary>
        [JsonPropertyName("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 配置显示名称
        /// </summary>
        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// 域ID
        /// </summary>
        [JsonPropertyName("domain_id")]
        public string DomainId { get; set; }

        /// <summary>
        /// 完结时间间隔（毫秒）
        /// </summary>
        [JsonPropertyName("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_property")]
        public string ExtProperty { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 完结时间
        /// </summary>
        [JsonPropertyName("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 幂等ID
        /// </summary>
        [JsonPropertyName("idempotent_id")]
        public string IdempotentId { get; set; }

        /// <summary>
        /// 业务属性列表, 列表长度为10
        /// </summary>
        [JsonPropertyName("info_values")]
        public List<string> InfoValues { get; set; }

        /// <summary>
        /// 流程租户ID
        /// </summary>
        [JsonPropertyName("instance_tnt_inst_id")]
        public string InstanceTntInstId { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 上一步操作
        /// </summary>
        [JsonPropertyName("last_operate")]
        public string LastOperate { get; set; }

        /// <summary>
        /// 紧急程度
        /// </summary>
        [JsonPropertyName("level")]
        public long Level { get; set; }

        /// <summary>
        /// 修改人用户域名
        /// </summary>
        [JsonPropertyName("modify_operator")]
        public string ModifyOperator { get; set; }

        /// <summary>
        /// 修改者姓名
        /// </summary>
        [JsonPropertyName("modify_operator_name")]
        public string ModifyOperatorName { get; set; }

        /// <summary>
        /// 工单名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 父工单id
        /// </summary>
        [JsonPropertyName("parent_ticket_id")]
        public long ParentTicketId { get; set; }

        /// <summary>
        /// 关联的某个版本的流程id
        /// </summary>
        [JsonPropertyName("process_id")]
        public string ProcessId { get; set; }

        /// <summary>
        /// 预期结束时间
        /// </summary>
        [JsonPropertyName("should_finish_time")]
        public string ShouldFinishTime { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// 同步到的第三方平台
        /// </summary>
        [JsonPropertyName("third_party")]
        public string ThirdParty { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [JsonPropertyName("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// 无线端工单详情地址
        /// </summary>
        [JsonPropertyName("wireless_detail_url")]
        public string WirelessDetailUrl { get; set; }
    }
}
