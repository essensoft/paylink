using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayAssetPointBalanceQueryResponse.
    /// </summary>
    public class AlipayAssetPointBalanceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户的集分宝余额
        /// </summary>
        [JsonPropertyName("point_amount")]
        public long PointAmount { get; set; }
    }
}
