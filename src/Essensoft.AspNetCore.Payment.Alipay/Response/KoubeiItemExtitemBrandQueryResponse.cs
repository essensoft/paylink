using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiItemExtitemBrandQueryResponse.
    /// </summary>
    public class KoubeiItemExtitemBrandQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 品牌列表信息
        /// </summary>
        [JsonProperty("brand_list")]
        [XmlArray("brand_list")]
        [XmlArrayItem("ext_brand")]
        public List<ExtBrand> BrandList { get; set; }
    }
}
