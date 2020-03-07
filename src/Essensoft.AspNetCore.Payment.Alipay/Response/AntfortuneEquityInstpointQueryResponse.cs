using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntfortuneEquityInstpointQueryResponse.
    /// </summary>
    public class AntfortuneEquityInstpointQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前积分值，表示用户在商户下的可用积分总值
        /// </summary>
        [JsonPropertyName("point_score")]
        public long PointScore { get; set; }
    }
}
