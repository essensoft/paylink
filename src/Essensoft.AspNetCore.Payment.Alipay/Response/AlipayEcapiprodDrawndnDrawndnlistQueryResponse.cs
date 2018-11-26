using System.Collections.Generic;
using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcapiprodDrawndnDrawndnlistQueryResponse.
    /// </summary>
    public class AlipayEcapiprodDrawndnDrawndnlistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支用列表
        /// </summary>
        [JsonProperty("drawndn_list")]
        [XmlArray("drawndn_list")]
        [XmlArrayItem("drawndn_vo")]
        public List<DrawndnVo> DrawndnList { get; set; }

        /// <summary>
        /// 唯一一次请求标示
        /// </summary>
        [JsonProperty("request_id")]
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
