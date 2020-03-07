using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsGoodssafetyinventoryModifyModel Data Structure.
    /// </summary>
    public class KoubeiRetailWmsGoodssafetyinventoryModifyModel : AlipayObject
    {
        /// <summary>
        /// 货品安全库存
        /// </summary>
        [JsonPropertyName("goods_safety_inventorys")]
        public List<GoodsSafetyInventory> GoodsSafetyInventorys { get; set; }
    }
}
