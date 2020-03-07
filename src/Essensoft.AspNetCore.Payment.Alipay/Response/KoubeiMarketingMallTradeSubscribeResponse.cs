using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingMallTradeSubscribeResponse.
    /// </summary>
    public class KoubeiMarketingMallTradeSubscribeResponse : AlipayResponse
    {
        /// <summary>
        /// 申请工单id（用以查询申请工单状态）
        /// </summary>
        [JsonPropertyName("order_flow_id")]
        public string OrderFlowId { get; set; }
    }
}
