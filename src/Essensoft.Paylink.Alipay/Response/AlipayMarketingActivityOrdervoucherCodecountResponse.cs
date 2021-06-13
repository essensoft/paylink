using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingActivityOrdervoucherCodecountResponse.
    /// </summary>
    public class AlipayMarketingActivityOrdervoucherCodecountResponse : AlipayResponse
    {
        /// <summary>
        /// 已经导入的券码数量
        /// </summary>
        [JsonPropertyName("success_count")]
        public long SuccessCount { get; set; }
    }
}
