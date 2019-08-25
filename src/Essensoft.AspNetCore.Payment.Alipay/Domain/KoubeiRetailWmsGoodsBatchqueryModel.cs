using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsGoodsBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsGoodsBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 货品编码，限制批量查询100个
        /// </summary>
        [JsonProperty("goods_codes")]
        public List<string> GoodsCodes { get; set; }
    }
}
