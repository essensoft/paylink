using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
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
