using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCraftsmanDataWorkCreateResponse.
    /// </summary>
    public class KoubeiCraftsmanDataWorkCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 作品id
        /// </summary>
        [JsonProperty("works")]
        [XmlArray("works")]
        [XmlArrayItem("craftsman_work_out_id_open_model")]
        public List<CraftsmanWorkOutIdOpenModel> Works { get; set; }
    }
}
