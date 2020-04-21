using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserPointAuthbaseSendResponse.
    /// </summary>
    public class AlipayUserPointAuthbaseSendResponse : AlipayResponse
    {
        /// <summary>
        /// 实际给用户发放的积分数，由于单个用户有日限额，所以实际发放的积分数可能小于请求发放的积分数
        /// </summary>
        [JsonPropertyName("send_point")]
        public long SendPoint { get; set; }
    }
}
