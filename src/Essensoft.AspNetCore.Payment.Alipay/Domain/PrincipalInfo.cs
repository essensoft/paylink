using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PrincipalInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PrincipalInfo : AlipayObject
    {
        /// <summary>
        /// 用户手机号
        /// </summary>
        [JsonProperty("mobile_no")]
        [XmlElement("mobile_no")]
        public string MobileNo { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [JsonProperty("operator_cert_no")]
        [XmlElement("operator_cert_no")]
        public string OperatorCertNo { get; set; }

        /// <summary>
        /// 证件类型，例如身份证，护照等
        /// </summary>
        [JsonProperty("operator_cert_type")]
        [XmlElement("operator_cert_type")]
        public string OperatorCertType { get; set; }

        /// <summary>
        /// 用户主体信息的扩展参数
        /// </summary>
        [JsonProperty("params")]
        [XmlElement("params")]
        public string Params { get; set; }

        /// <summary>
        /// 租户信息
        /// </summary>
        [JsonProperty("tnt_inst_id")]
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// 业务方传入的用户标识
        /// </summary>
        [JsonProperty("user_id")]
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        [JsonProperty("user_name")]
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
