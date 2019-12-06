using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandItemOpenBatchqueryResponse.
    /// </summary>
    public class AntMerchantExpandItemOpenBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商品列表
        /// </summary>
        [JsonPropertyName("item_list")]
        public List<CmItemInfo> ItemList { get; set; }
    }
}
