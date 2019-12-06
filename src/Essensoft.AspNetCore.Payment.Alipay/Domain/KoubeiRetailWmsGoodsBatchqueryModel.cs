using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsGoodsBatchqueryModel Data Structure.
    /// </summary>
    public class KoubeiRetailWmsGoodsBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 货品编码，限制批量查询100个
        /// </summary>
        [JsonPropertyName("goods_codes")]
        public List<string> GoodsCodes { get; set; }
    }
}
