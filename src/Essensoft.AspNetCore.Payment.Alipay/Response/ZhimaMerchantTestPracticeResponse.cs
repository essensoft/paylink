using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaMerchantTestPracticeResponse.
    /// </summary>
    public class ZhimaMerchantTestPracticeResponse : AlipayResponse
    {
        /// <summary>
        /// xxxx
        /// </summary>
        [JsonPropertyName("dddd")]
        public XXXXsdasdasd Dddd { get; set; }

        /// <summary>
        /// ccc
        /// </summary>
        [JsonPropertyName("sss")]
        public string Sss { get; set; }
    }
}
