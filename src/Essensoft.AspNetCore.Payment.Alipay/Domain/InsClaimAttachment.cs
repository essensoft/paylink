using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsClaimAttachment Data Structure.
    /// </summary>
    [Serializable]
    public class InsClaimAttachment : AlipayObject
    {
        /// <summary>
        /// 材料描述
        /// </summary>
        [JsonProperty("description")]
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 附件对应的路径
        /// </summary>
        [JsonProperty("path")]
        [XmlElement("path")]
        public string Path { get; set; }

        /// <summary>
        /// 审核理由
        /// </summary>
        [JsonProperty("reason")]
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 材料审核状态
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 附件类型
        /// </summary>
        [JsonProperty("type")]
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
