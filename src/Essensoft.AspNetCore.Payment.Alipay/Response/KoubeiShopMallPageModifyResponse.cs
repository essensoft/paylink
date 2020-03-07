using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiShopMallPageModifyResponse.
    /// </summary>
    public class KoubeiShopMallPageModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 工单id（用以查询创建，修改操作的审核状态）
        /// </summary>
        [JsonPropertyName("order_flow_id")]
        public string OrderFlowId { get; set; }
    }
}
