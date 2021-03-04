using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMicropayOrderFreezepayurlGetResponse.
    /// </summary>
    public class AlipayMicropayOrderFreezepayurlGetResponse : AlipayResponse
    {
        /// <summary>
        /// 支付冻结金的地址
        /// </summary>
        [JsonPropertyName("pay_freeze_url")]
        public string PayFreezeUrl { get; set; }
    }
}
