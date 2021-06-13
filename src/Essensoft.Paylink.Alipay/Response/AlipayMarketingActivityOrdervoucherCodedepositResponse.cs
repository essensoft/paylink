using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingActivityOrdervoucherCodedepositResponse.
    /// </summary>
    public class AlipayMarketingActivityOrdervoucherCodedepositResponse : AlipayResponse
    {
        /// <summary>
        /// 导入失败的券码数量
        /// </summary>
        [JsonPropertyName("fail_count")]
        public long FailCount { get; set; }

        /// <summary>
        /// 导入成功的券码数量
        /// </summary>
        [JsonPropertyName("success_count")]
        public long SuccessCount { get; set; }
    }
}
