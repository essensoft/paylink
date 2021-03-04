using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenInstantdeliveryMerchantagreementSignResponse.
    /// </summary>
    public class AlipayOpenInstantdeliveryMerchantagreementSignResponse : AlipayResponse
    {
        /// <summary>
        /// 授权二维码的url, 必须用传入的uid进行扫码
        /// </summary>
        [JsonPropertyName("sign_url")]
        public string SignUrl { get; set; }
    }
}
