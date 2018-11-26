using System.Collections.Generic;
using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorCityQueryResponse.
    /// </summary>
    public class AlipayCommerceCityfacilitatorCityQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 城市列表
        /// </summary>
        [JsonProperty("citys")]
        [XmlArray("citys")]
        [XmlArrayItem("city_function")]
        public List<CityFunction> Citys { get; set; }
    }
}
