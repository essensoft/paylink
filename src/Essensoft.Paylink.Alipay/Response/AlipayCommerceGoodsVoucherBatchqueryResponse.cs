using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceGoodsVoucherBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceGoodsVoucherBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 活动信息
        /// </summary>
        [JsonPropertyName("activities")]
        public List<CampVoucherInfo> Activities { get; set; }
    }
}
