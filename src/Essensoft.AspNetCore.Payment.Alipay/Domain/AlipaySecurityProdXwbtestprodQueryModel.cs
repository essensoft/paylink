using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityProdXwbtestprodQueryModel Data Structure.
    /// </summary>
    public class AlipaySecurityProdXwbtestprodQueryModel : AlipayObject
    {
        /// <summary>
        /// Stop
        /// </summary>
        [JsonPropertyName("in_a")]
        public string InA { get; set; }

        /// <summary>
        /// 省份编码，国标码
        /// </summary>
        [JsonPropertyName("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// wert
        /// </summary>
        [JsonPropertyName("qwe_dfgfd")]
        public string QweDfgfd { get; set; }
    }
}
