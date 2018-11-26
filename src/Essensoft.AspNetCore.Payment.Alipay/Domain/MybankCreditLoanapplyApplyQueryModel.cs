using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditLoanapplyApplyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoanapplyApplyQueryModel : AlipayObject
    {
        /// <summary>
        /// 证件号码
        /// </summary>
        [JsonProperty("cert_no")]
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [JsonProperty("cert_type")]
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 扩展查询参数
        /// </summary>
        [JsonProperty("ext_params")]
        [XmlElement("ext_params")]
        public string ExtParams { get; set; }

        /// <summary>
        /// 客户姓名
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 子申请单编号
        /// </summary>
        [JsonProperty("subapply_no")]
        [XmlElement("subapply_no")]
        public string SubapplyNo { get; set; }
    }
}
