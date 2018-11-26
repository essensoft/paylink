using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsCooperationRegionQrcodeApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsCooperationRegionQrcodeApplyModel : AlipayObject
    {
        /// <summary>
        /// 保险代理人在保险公司的惟一ID，数据来自保险公司内部管理系统
        /// </summary>
        [JsonProperty("agent_id")]
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 代理人姓名
        /// </summary>
        [JsonProperty("agent_name")]
        [XmlElement("agent_name")]
        public string AgentName { get; set; }

        /// <summary>
        /// 代理人手机号码
        /// </summary>
        [JsonProperty("agent_phone")]
        [XmlElement("agent_phone")]
        public string AgentPhone { get; set; }

        /// <summary>
        /// 保险公司在蚂蚁保险平台的惟一ID，由蚂蚁保险平台分配。
        /// </summary>
        [JsonProperty("inst_id")]
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 产品编码列表，蚂蚁保险平台会为每个产品分配一个唯一的产品编码
        /// </summary>
        [JsonProperty("prod_code_list")]
        [XmlArray("prod_code_list")]
        [XmlArrayItem("string")]
        public List<string> ProdCodeList { get; set; }

        /// <summary>
        /// 专区在保险公司的惟一ID，数据来自保险公司内部管理系统
        /// </summary>
        [JsonProperty("region_id")]
        [XmlElement("region_id")]
        public string RegionId { get; set; }

        /// <summary>
        /// 专区名称，会作为机构保险号首页的专区名称做展示
        /// </summary>
        [JsonProperty("region_name")]
        [XmlElement("region_name")]
        public string RegionName { get; set; }
    }
}
