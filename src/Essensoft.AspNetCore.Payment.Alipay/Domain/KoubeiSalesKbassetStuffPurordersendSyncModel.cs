using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiSalesKbassetStuffPurordersendSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiSalesKbassetStuffPurordersendSyncModel : AlipayObject
    {
        /// <summary>
        /// 供应商同步的发货信息及物流信息记录（最多100条）
        /// </summary>
        [JsonProperty("purchase_order_sends")]
        public List<AccessPurchaseOrderSend> PurchaseOrderSends { get; set; }
    }
}
