using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTradeSettleReceivablesQueryResponse.
    /// </summary>
    public class AlipayTradeSettleReceivablesQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 待结算金额，人民币，单位为元
        /// </summary>
        [JsonPropertyName("unsettled_amount")]
        public string UnsettledAmount { get; set; }
    }
}
