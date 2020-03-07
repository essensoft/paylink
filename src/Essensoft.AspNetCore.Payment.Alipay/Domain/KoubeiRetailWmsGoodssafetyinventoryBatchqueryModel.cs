using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsGoodssafetyinventoryBatchqueryModel Data Structure.
    /// </summary>
    public class KoubeiRetailWmsGoodssafetyinventoryBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 货品编码，限制最大查询数量1000
        /// </summary>
        [JsonPropertyName("goods_codes")]
        public List<string> GoodsCodes { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [JsonPropertyName("warehouse_code")]
        public string WarehouseCode { get; set; }
    }
}
