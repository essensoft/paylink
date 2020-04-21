using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiRetailWmsBatchinventoryQueryResponse.
    /// </summary>
    public class KoubeiRetailWmsBatchinventoryQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 库存信息列表
        /// </summary>
        [JsonPropertyName("inventory_list")]
        public List<Inventory> InventoryList { get; set; }
    }
}
