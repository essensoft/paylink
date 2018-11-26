using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityRiskPolicyConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskPolicyConfirmModel : AlipayObject
    {
        /// <summary>
        /// 二次确认参数，防止篡改
        /// </summary>
        [JsonProperty("confirm_params")]
        [XmlElement("confirm_params")]
        public string ConfirmParams { get; set; }

        /// <summary>
        /// 安全请求生成的唯一ID
        /// </summary>
        [JsonProperty("security_id")]
        [XmlElement("security_id")]
        public string SecurityId { get; set; }
    }
}
