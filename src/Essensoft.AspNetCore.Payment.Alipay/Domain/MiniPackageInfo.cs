using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MiniPackageInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MiniPackageInfo : AlipayObject
    {
        /// <summary>
        /// 功能包文档地址
        /// </summary>
        [JsonProperty("doc_url")]
        [XmlElement("doc_url")]
        public string DocUrl { get; set; }

        /// <summary>
        /// 功能包描述
        /// </summary>
        [JsonProperty("package_desc")]
        [XmlElement("package_desc")]
        public string PackageDesc { get; set; }

        /// <summary>
        /// 功能包名称
        /// </summary>
        [JsonProperty("package_name")]
        [XmlElement("package_name")]
        public string PackageName { get; set; }

        /// <summary>
        /// 功能包开通方式，"APPLY", "申请开通"；"ORDER", "签约开通"；"DEFAULT", "默认开通"
        /// </summary>
        [JsonProperty("package_open_type")]
        [XmlElement("package_open_type")]
        public string PackageOpenType { get; set; }

        /// <summary>
        /// 功能包签约状态，"valid", "已生效"；"audit", "签约中"；"invalid", "已失效"；"none", "未签约"
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
