using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayBossProdSubaccountBalanceQueryResponse.
    /// </summary>
    public class AlipayBossProdSubaccountBalanceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 子户余额信息
        /// </summary>
        [JsonPropertyName("result_set")]
        public SubAccountBalanceOpenApiDTO ResultSet { get; set; }
    }
}
