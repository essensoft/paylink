using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceLbsDiscountBatchqueryResponse.
    /// </summary>
    public class AlipayDataDataserviceLbsDiscountBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 广告投放出去的商品信息
        /// </summary>
        [JsonPropertyName("discounts")]
        public List<AntlbsKBDiscountInfo> Discounts { get; set; }
    }
}
