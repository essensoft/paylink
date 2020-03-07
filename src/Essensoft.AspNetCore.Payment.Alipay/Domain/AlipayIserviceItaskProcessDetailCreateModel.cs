using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceItaskProcessDetailCreateModel Data Structure.
    /// </summary>
    public class AlipayIserviceItaskProcessDetailCreateModel : AlipayObject
    {
        /// <summary>
        /// 接口服务端名称
        /// </summary>
        [JsonPropertyName("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 附件地址
        /// </summary>
        [JsonPropertyName("attachment")]
        public string Attachment { get; set; }

        /// <summary>
        /// 接口客户端名称
        /// </summary>
        [JsonPropertyName("exapp_name")]
        public string ExappName { get; set; }

        /// <summary>
        /// 外部工单创建人ID
        /// </summary>
        [JsonPropertyName("excreator_id")]
        public string ExcreatorId { get; set; }

        /// <summary>
        /// 外部工单创建人名称
        /// </summary>
        [JsonPropertyName("excreator_name")]
        public string ExcreatorName { get; set; }

        /// <summary>
        /// 外部工单创建人部门ID
        /// </summary>
        [JsonPropertyName("exsystem_department_id")]
        public string ExsystemDepartmentId { get; set; }

        /// <summary>
        /// BU名称（xspace填写对应的租户名称）
        /// </summary>
        [JsonPropertyName("exsystem_department_name")]
        public string ExsystemDepartmentName { get; set; }

        /// <summary>
        /// 外部工单业务扩展字段列表，业务属性信息都放置在此字段。最多10个字段。
        /// </summary>
        [JsonPropertyName("extend_field_infos")]
        public List<ExtendFieldInfo> ExtendFieldInfos { get; set; }

        /// <summary>
        /// 工单流程编号
        /// </summary>
        [JsonPropertyName("process_no")]
        public string ProcessNo { get; set; }

        /// <summary>
        /// 工单流程编号_服务端提供给消费端流程模板code
        /// </summary>
        [JsonPropertyName("process_template_code")]
        public string ProcessTemplateCode { get; set; }
    }
}
