using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SecurityScene Data Structure.
    /// </summary>
    [Serializable]
    public class SecurityScene : AlipayObject
    {
        /// <summary>
        /// 接入渠道
        /// </summary>
        [JsonProperty("access_channel")]
        [XmlElement("access_channel")]
        public string AccessChannel { get; set; }

        /// <summary>
        /// 事件信息
        /// </summary>
        [JsonProperty("ctu_params")]
        [XmlElement("ctu_params")]
        public string CtuParams { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [JsonProperty("product_name")]
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 产品节点
        /// </summary>
        [JsonProperty("product_node")]
        [XmlElement("product_node")]
        public string ProductNode { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [JsonProperty("security_scene_params")]
        [XmlElement("security_scene_params")]
        public string SecuritySceneParams { get; set; }

        /// <summary>
        /// 系统名称
        /// </summary>
        [JsonProperty("system_name")]
        [XmlElement("system_name")]
        public string SystemName { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        [JsonProperty("total_fee")]
        [XmlElement("total_fee")]
        public string TotalFee { get; set; }
    }
}
