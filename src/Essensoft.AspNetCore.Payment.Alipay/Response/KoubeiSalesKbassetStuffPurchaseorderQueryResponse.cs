using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiSalesKbassetStuffPurchaseorderQueryResponse.
    /// </summary>
    public class KoubeiSalesKbassetStuffPurchaseorderQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 采购单记录集合
        /// </summary>
        [JsonPropertyName("asset_purchase_orders")]
        public List<AccessPurchaseOrder> AssetPurchaseOrders { get; set; }

        /// <summary>
        /// 是否有下一页
        /// </summary>
        [JsonPropertyName("has_next_page")]
        public bool HasNextPage { get; set; }
    }
}
