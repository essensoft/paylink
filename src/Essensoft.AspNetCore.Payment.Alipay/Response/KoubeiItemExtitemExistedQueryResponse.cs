using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiItemExtitemExistedQueryResponse.
    /// </summary>
    public class KoubeiItemExtitemExistedQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商品库中存在的商品编码
        /// </summary>
        [JsonProperty("existed_list")]
        [XmlArray("existed_list")]
        [XmlArrayItem("string")]
        public List<string> ExistedList { get; set; }
    }
}
