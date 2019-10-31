using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandItemOpenBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandItemOpenBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 商品ID列表
        /// </summary>
        [JsonProperty("item_id_list")]
        public List<string> ItemIdList { get; set; }
    }
}
