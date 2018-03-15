using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityProdXwbtestprodQueryModel Data Structure.
    /// </summary>
    public class AlipaySecurityProdXwbtestprodQueryModel : AlipayObject
    {
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
