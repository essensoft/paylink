using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceItaskProcessDetailModifyModel Data Structure.
    /// </summary>
    public class AlipayIserviceItaskProcessDetailModifyModel : AlipayObject
    {
        /// <summary>
        /// 工单平台名称
        /// </summary>
        [JsonPropertyName("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 工单附件的存储地址
        /// </summary>
        [JsonPropertyName("attachment")]
        public string Attachment { get; set; }

        /// <summary>
        /// 接口客户端名称
        /// </summary>
        [JsonPropertyName("exapp_name")]
        public string ExappName { get; set; }

        /// <summary>
        /// 外部系统对工单进行处理的人员所在部门ID。
        /// </summary>
        [JsonPropertyName("exsystem_department_id")]
        public string ExsystemDepartmentId { get; set; }

        /// <summary>
        /// BU名称（XSPACE填写对应租户名称）
        /// </summary>
        [JsonPropertyName("exsystem_department_name")]
        public string ExsystemDepartmentName { get; set; }

        /// <summary>
        /// 外部系统对工单的处理动作。前期与外部系统沟通后，提供给外部系统。枚举（agree，reject）
        /// </summary>
        [JsonPropertyName("exsystem_operate")]
        public string ExsystemOperate { get; set; }

        /// <summary>
        /// 外部系统对工单进行处理的备注信息
        /// </summary>
        [JsonPropertyName("exsystem_operator_comment")]
        public string ExsystemOperatorComment { get; set; }

        /// <summary>
        /// 外部系统对工单进行处理的人员ID。
        /// </summary>
        [JsonPropertyName("exsystem_operator_id")]
        public string ExsystemOperatorId { get; set; }

        /// <summary>
        /// 外部系统对工单进行处理的人员名称。
        /// </summary>
        [JsonPropertyName("exsystem_operator_name")]
        public string ExsystemOperatorName { get; set; }

        /// <summary>
        /// 外部工单业务扩展字段，业务属性信息都放置在此字段。最大10个字段。
        /// </summary>
        [JsonPropertyName("extend_field_infos")]
        public List<ExtendFieldInfo> ExtendFieldInfos { get; set; }

        /// <summary>
        /// 工单流程编号
        /// </summary>
        [JsonPropertyName("process_no")]
        public string ProcessNo { get; set; }

        /// <summary>
        /// 工单流程编码_服务端提供给消费端流程模板code
        /// </summary>
        [JsonPropertyName("process_template_code")]
        public string ProcessTemplateCode { get; set; }

        /// <summary>
        /// 工单信息唯一标识ID，简写为puid。为app_name、process_no和alipay_process_id共同组合而成，供工单推进接口使用。
        /// </summary>
        [JsonPropertyName("process_unique_id")]
        public string ProcessUniqueId { get; set; }
    }
}
