using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingFacetofaceTwostageUseResponse.
    /// </summary>
    public class AlipayMarketingFacetofaceTwostageUseResponse : AlipayResponse
    {
        /// <summary>
        /// 业务扩展数据
        /// </summary>
        [JsonPropertyName("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 淘宝会员ID
        /// </summary>
        [JsonPropertyName("havana_id")]
        public string HavanaId { get; set; }

        /// <summary>
        /// otp校验结果
        /// </summary>
        [JsonPropertyName("otp_verify")]
        public string OtpVerify { get; set; }

        /// <summary>
        /// 用户userId
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
