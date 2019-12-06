using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiSalesKbassetStuffPurordersendSyncModel Data Structure.
    /// </summary>
    public class KoubeiSalesKbassetStuffPurordersendSyncModel : AlipayObject
    {
        /// <summary>
        /// 供应商同步的发货信息及物流信息记录（最多100条）
        /// </summary>
        [JsonPropertyName("purchase_order_sends")]
        public List<AccessPurchaseOrderSend> PurchaseOrderSends { get; set; }
    }
}
