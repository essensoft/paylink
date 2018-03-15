using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityRiskCustomerriskSendModel Data Structure.
    /// </summary>
    public class AlipaySecurityRiskCustomerriskSendModel : AlipayObject
    {
        /// <summary>
        /// 身份证号码
        /// </summary>
        [JsonProperty("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("mobile")]
        public string Mobile { get; set; }
    }
}
