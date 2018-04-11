using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserFinanceinfoShareModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserFinanceinfoShareModel : AlipayObject
    {
        /// <summary>
        /// 支付宝会员的userId
        /// </summary>
        [JsonProperty("user_id")]
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
