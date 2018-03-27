using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

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
        public List<CityFunction> Citys { get; set; }
    }
}
