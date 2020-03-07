using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFundCouponWufuCardQueryResponse.
    /// </summary>
    public class AlipayFundCouponWufuCardQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 领取福卡总数
        /// </summary>
        [JsonPropertyName("count")]
        public long Count { get; set; }
    }
}
