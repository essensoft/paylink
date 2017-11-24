using Newtonsoft.Json;
using Essensoft.AspNetCore.Alipay.Domain;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayMicropayOrderConfirmpayurlGetResponse.
    /// </summary>
    public class AlipayMicropayOrderConfirmpayurlGetResponse : AlipayResponse
    {
        /// <summary>
        /// SinglePayDetail信息
        /// </summary>
        [JsonProperty("single_pay_detail")]
        public SinglePayDetail SinglePayDetail { get; set; }
    }
}
