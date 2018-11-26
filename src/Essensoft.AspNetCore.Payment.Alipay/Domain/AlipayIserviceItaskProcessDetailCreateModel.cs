using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceItaskProcessDetailCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceItaskProcessDetailCreateModel : AlipayObject
    {
        /// <summary>
        /// 接口服务端名称
        /// </summary>
        [JsonProperty("app_name")]
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 附件地址
        /// </summary>
        [JsonProperty("attachment")]
        [XmlElement("attachment")]
        public string Attachment { get; set; }

        /// <summary>
        /// 接口客户端名称
        /// </summary>
        [JsonProperty("exapp_name")]
        [XmlElement("exapp_name")]
        public string ExappName { get; set; }

        /// <summary>
        /// 外部工单创建人ID
        /// </summary>
        [JsonProperty("excreator_id")]
        [XmlElement("excreator_id")]
        public string ExcreatorId { get; set; }

        /// <summary>
        /// 外部工单创建人名称
        /// </summary>
        [JsonProperty("excreator_name")]
        [XmlElement("excreator_name")]
        public string ExcreatorName { get; set; }

        /// <summary>
        /// 外部工单创建人部门ID
        /// </summary>
        [JsonProperty("exsystem_department_id")]
        [XmlElement("exsystem_department_id")]
        public string ExsystemDepartmentId { get; set; }

        /// <summary>
        /// BU名称（xspace填写对应的租户名称）
        /// </summary>
        [JsonProperty("exsystem_department_name")]
        [XmlElement("exsystem_department_name")]
        public string ExsystemDepartmentName { get; set; }

        /// <summary>
        /// 外部工单业务扩展字段列表，业务属性信息都放置在此字段。最多10个字段。
        /// </summary>
        [JsonProperty("extend_field_infos")]
        [XmlArray("extend_field_infos")]
        [XmlArrayItem("extend_field_info")]
        public List<ExtendFieldInfo> ExtendFieldInfos { get; set; }

        /// <summary>
        /// 工单流程编号
        /// </summary>
        [JsonProperty("process_no")]
        [XmlElement("process_no")]
        public string ProcessNo { get; set; }

        /// <summary>
        /// 工单流程编号_服务端提供给消费端流程模板code
        /// </summary>
        [JsonProperty("process_template_code")]
        [XmlElement("process_template_code")]
        public string ProcessTemplateCode { get; set; }
    }
}
