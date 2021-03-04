using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayTradeRoyaltyRelationBindResponse.
    /// </summary>
    public class AlipayTradeRoyaltyRelationBindResponse : AlipayResponse
    {
        /// <summary>
        /// SUCCESS：分账关系绑定成功； FAIL：分账关系绑定失败。
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }
    }
}
