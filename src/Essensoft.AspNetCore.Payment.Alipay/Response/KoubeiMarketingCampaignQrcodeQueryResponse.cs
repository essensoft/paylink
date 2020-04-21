using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignQrcodeQueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignQrcodeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 二维码地址，可以根据这个地址生成二维码
        /// </summary>
        [JsonPropertyName("qrcode_url")]
        public string QrcodeUrl { get; set; }
    }
}
