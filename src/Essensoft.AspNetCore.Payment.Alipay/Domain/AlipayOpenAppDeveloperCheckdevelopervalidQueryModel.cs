using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppDeveloperCheckdevelopervalidQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppDeveloperCheckdevelopervalidQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝账号
        /// </summary>
        [JsonProperty("logon_id")]
        [XmlElement("logon_id")]
        public string LogonId { get; set; }
    }
}
