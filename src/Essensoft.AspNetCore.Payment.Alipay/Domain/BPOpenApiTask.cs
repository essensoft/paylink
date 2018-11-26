using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BPOpenApiTask Data Structure.
    /// </summary>
    [Serializable]
    public class BPOpenApiTask : AlipayObject
    {
        /// <summary>
        /// 处理地址
        /// </summary>
        [JsonProperty("deal_url")]
        [XmlElement("deal_url")]
        public string DealUrl { get; set; }

        /// <summary>
        /// 详情展示地址
        /// </summary>
        [JsonProperty("detail_url")]
        [XmlElement("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 审批节点中文显示名称
        /// </summary>
        [JsonProperty("display_name")]
        [XmlElement("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        [JsonProperty("gmt_operate")]
        [XmlElement("gmt_operate")]
        public string GmtOperate { get; set; }

        /// <summary>
        /// 处理备注信息
        /// </summary>
        [JsonProperty("memo")]
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 审批节点code
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 点击的操作按钮
        /// </summary>
        [JsonProperty("operate")]
        [XmlElement("operate")]
        public string Operate { get; set; }

        /// <summary>
        /// 可点击的操作
        /// </summary>
        [JsonProperty("operate_transition")]
        [XmlElement("operate_transition")]
        public string OperateTransition { get; set; }

        /// <summary>
        /// 处理人域账号
        /// </summary>
        [JsonProperty("operator")]
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 处理人花名
        /// </summary>
        [JsonProperty("operator_name")]
        [XmlElement("operator_name")]
        public string OperatorName { get; set; }

        /// <summary>
        /// 加签类型
        /// </summary>
        [JsonProperty("sign_type")]
        [XmlElement("sign_type")]
        public string SignType { get; set; }

        /// <summary>
        /// 状态:CREATED,TAKEN,TEMP_SAVE,COMPLETED,CANCELED
        /// </summary>
        [JsonProperty("state")]
        [XmlElement("state")]
        public string State { get; set; }

        /// <summary>
        /// 节点类型：UserTask，SystemTask
        /// </summary>
        [JsonProperty("type")]
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
