using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiServindustryShopLicenseQueryResponse.
    /// </summary>
    public class KoubeiServindustryShopLicenseQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 有一家shop有营业执照：true  所有shop无营业执照：false
        /// </summary>
        [JsonPropertyName("have_permit")]
        public bool HavePermit { get; set; }
    }
}
