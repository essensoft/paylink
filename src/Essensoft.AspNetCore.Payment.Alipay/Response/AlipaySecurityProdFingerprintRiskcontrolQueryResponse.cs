using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdFingerprintRiskcontrolQueryResponse.
    /// </summary>
    public class AlipaySecurityProdFingerprintRiskcontrolQueryResponse : AlipayResponse
    {
        /// <summary>
        /// IFAA服务端查询结果，true为支持指纹功能，false为不支持
        /// </summary>
        [JsonProperty("check_result")]
        [XmlElement("check_result")]
        public bool CheckResult { get; set; }
    }
}
