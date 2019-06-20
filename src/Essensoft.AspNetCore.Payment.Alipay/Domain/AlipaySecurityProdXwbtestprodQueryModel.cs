using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityProdXwbtestprodQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdXwbtestprodQueryModel : AlipayObject
    {
        /// <summary>
        /// Stop
        /// </summary>
        [JsonProperty("in_a")]
        public string InA { get; set; }

        /// <summary>
        /// 省份编码，国标码
        /// </summary>
        [JsonProperty("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// wert
        /// </summary>
        [JsonProperty("qwe_dfgfd")]
        public string QweDfgfd { get; set; }
    }
}
