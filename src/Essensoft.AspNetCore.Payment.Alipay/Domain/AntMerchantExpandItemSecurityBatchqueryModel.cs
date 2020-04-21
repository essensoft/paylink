using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandItemSecurityBatchqueryModel Data Structure.
    /// </summary>
    public class AntMerchantExpandItemSecurityBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 商品ID列表
        /// </summary>
        [JsonPropertyName("item_id_list")]
        public List<string> ItemIdList { get; set; }
    }
}
