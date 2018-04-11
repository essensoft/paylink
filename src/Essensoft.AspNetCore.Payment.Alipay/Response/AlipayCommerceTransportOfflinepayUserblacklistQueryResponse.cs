using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportOfflinepayUserblacklistQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportOfflinepayUserblacklistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 黑名单用户ID
        /// </summary>
        [JsonProperty("black_list")]
        [XmlArray("black_list")]
        [XmlArrayItem("string")]
        public List<string> BlackList { get; set; }
    }
}
