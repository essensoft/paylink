using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicPayeeBindDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicPayeeBindDeleteModel : AlipayObject
    {
        /// <summary>
        /// 收款账号，需要解除绑定的收款支付宝账号
        /// </summary>
        [JsonProperty("login_id")]
        [XmlElement("login_id")]
        public string LoginId { get; set; }
    }
}
