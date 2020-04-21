using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySamsungPucChargeResponse.
    /// </summary>
    public class AlipaySamsungPucChargeResponse : AlipayResponse
    {
        /// <summary>
        /// zhijiefanhui yemian
        /// </summary>
        [JsonPropertyName("page_retrun")]
        public string PageRetrun { get; set; }
    }
}
