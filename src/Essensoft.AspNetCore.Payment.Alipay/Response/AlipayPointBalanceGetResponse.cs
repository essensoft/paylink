using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPointBalanceGetResponse.
    /// </summary>
    public class AlipayPointBalanceGetResponse : AlipayResponse
    {
        /// <summary>
        /// 用户的集分宝余额
        /// </summary>
        [JsonPropertyName("point_amount")]
        public long PointAmount { get; set; }
    }
}
