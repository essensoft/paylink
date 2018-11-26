using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserAccountGetResponse.
    /// </summary>
    public class AlipayUserAccountGetResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝用户账户信息
        /// </summary>
        [JsonProperty("alipay_account")]
        [XmlElement("alipay_account")]
        public AlipayAccount AlipayAccount { get; set; }
    }
}
