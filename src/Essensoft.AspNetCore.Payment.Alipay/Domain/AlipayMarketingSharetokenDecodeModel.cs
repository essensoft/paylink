using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingSharetokenDecodeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingSharetokenDecodeModel : AlipayObject
    {
        /// <summary>
        /// 码类型，可空，默认为吱口令类型『share_code』
        /// </summary>
        [JsonProperty("code_type")]
        [XmlElement("code_type")]
        public string CodeType { get; set; }

        /// <summary>
        /// 扩展属性，key-value json串
        /// </summary>
        [JsonProperty("ext_data")]
        [XmlElement("ext_data")]
        public string ExtData { get; set; }

        /// <summary>
        /// 8位吱口令token
        /// </summary>
        [JsonProperty("token")]
        [XmlElement("token")]
        public string Token { get; set; }
    }
}
