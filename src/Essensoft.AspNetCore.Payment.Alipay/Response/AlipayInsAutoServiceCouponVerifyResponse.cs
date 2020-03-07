using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsAutoServiceCouponVerifyResponse.
    /// </summary>
    public class AlipayInsAutoServiceCouponVerifyResponse : AlipayResponse
    {
        /// <summary>
        /// 核销同步结果，返回成功或失败。
        /// </summary>
        [JsonPropertyName("biz_success")]
        public bool BizSuccess { get; set; }
    }
}
