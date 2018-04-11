using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMemberRetailerQueryResponse.
    /// </summary>
    public class KoubeiMemberRetailerQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 零售商信息列表
        /// </summary>
        [JsonProperty("retailer_list")]
        [XmlArray("retailer_list")]
        [XmlArrayItem("retailer")]
        public List<Retailer> RetailerList { get; set; }
    }
}
