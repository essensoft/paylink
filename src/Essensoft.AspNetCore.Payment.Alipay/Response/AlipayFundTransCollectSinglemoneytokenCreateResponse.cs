using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFundTransCollectSinglemoneytokenCreateResponse.
    /// </summary>
    public class AlipayFundTransCollectSinglemoneytokenCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 其他扩展属性
        /// </summary>
        [JsonPropertyName("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 收钱二维码
        /// </summary>
        [JsonPropertyName("qr_code")]
        public string QrCode { get; set; }

        /// <summary>
        /// 吱口令文案
        /// </summary>
        [JsonPropertyName("zhi_token")]
        public string ZhiToken { get; set; }
    }
}
