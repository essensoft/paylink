using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiSalesKbassetStuffPurordersendSyncResponse.
    /// </summary>
    public class KoubeiSalesKbassetStuffPurordersendSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 供应商同步发货信息及物流信息处理结果列表
        /// </summary>
        [JsonPropertyName("purchase_order_send_results")]
        public List<AccessPurchaseOrderSendResult> PurchaseOrderSendResults { get; set; }
    }
}
