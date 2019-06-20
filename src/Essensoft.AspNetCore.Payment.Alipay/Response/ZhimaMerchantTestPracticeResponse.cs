using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

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
        [JsonProperty("dddd")]
        public XXXXsdasdasd Dddd { get; set; }

        /// <summary>
        /// ccc
        /// </summary>
        [JsonProperty("sss")]
        public string Sss { get; set; }
    }
}
