using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsGoodssafetyinventoryModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsGoodssafetyinventoryModifyModel : AlipayObject
    {
        /// <summary>
        /// 货品安全库存
        /// </summary>
        [JsonProperty("goods_safety_inventorys")]
        public List<GoodsSafetyInventory> GoodsSafetyInventorys { get; set; }
    }
}
