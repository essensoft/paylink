using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandItemOpenBatchqueryModel Data Structure.
    /// </summary>
    public class AntMerchantExpandItemOpenBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 商品ID列表，单次查询上限为 20。
        /// </summary>
        [JsonPropertyName("item_id_list")]
        public List<string> ItemIdList { get; set; }
    }
}
