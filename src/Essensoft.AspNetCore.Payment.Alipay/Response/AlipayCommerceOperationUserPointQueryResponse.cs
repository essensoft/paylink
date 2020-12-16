using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceOperationUserPointQueryResponse.
    /// </summary>
    public class AlipayCommerceOperationUserPointQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户当前可用积分
        /// </summary>
        [JsonPropertyName("current_point")]
        public long CurrentPoint { get; set; }

        /// <summary>
        /// 用户累计总积分
        /// </summary>
        [JsonPropertyName("total_point")]
        public long TotalPoint { get; set; }
    }
}
