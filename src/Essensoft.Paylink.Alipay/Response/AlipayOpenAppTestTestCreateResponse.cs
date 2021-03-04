using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppTestTestCreateResponse.
    /// </summary>
    public class AlipayOpenAppTestTestCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 省份
        /// </summary>
        [JsonPropertyName("province_code")]
        public string ProvinceCode { get; set; }
    }
}
