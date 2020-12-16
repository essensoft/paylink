using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppAppcontentItemBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppAppcontentItemBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 商品ID列表；最多20个ID
        /// </summary>
        [JsonPropertyName("item_ids")]
        public List<string> ItemIds { get; set; }
    }
}
