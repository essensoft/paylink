using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayBossFncSettleSettlementbillCreateResponse.
    /// </summary>
    public class AlipayBossFncSettleSettlementbillCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 返回参数
        /// </summary>
        [JsonPropertyName("result_set")]
        public SettlementbillOpenApiDTO ResultSet { get; set; }
    }
}
