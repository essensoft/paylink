using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicAccountCreateResponse.
    /// </summary>
    public class AlipayOpenPublicAccountCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 协议号，商户会员在支付宝服务窗账号中的唯一标识
        /// </summary>
        [JsonProperty("agreement_id")]
        [XmlElement("agreement_id")]
        public string AgreementId { get; set; }
    }
}
