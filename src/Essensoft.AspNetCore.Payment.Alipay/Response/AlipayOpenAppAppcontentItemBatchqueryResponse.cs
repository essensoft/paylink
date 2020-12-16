using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppAppcontentItemBatchqueryResponse.
    /// </summary>
    public class AlipayOpenAppAppcontentItemBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商品信息
        /// </summary>
        [JsonPropertyName("items")]
        public List<AppContentItem> Items { get; set; }
    }
}
