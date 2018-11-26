using System.Collections.Generic;
using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayAccountExrateAllclientrateQueryResponse.
    /// </summary>
    public class AlipayAccountExrateAllclientrateQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 汇率信息列表
        /// </summary>
        [JsonProperty("client_rate_list")]
        [XmlArray("client_rate_list")]
        [XmlArrayItem("ex_client_rate_v_o")]
        public List<ExClientRateVO> ClientRateList { get; set; }
    }
}
