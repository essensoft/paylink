using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMerchantOrderSecuritydigestConsumerBatchqueryResponse.
    /// </summary>
    public class AlipayMerchantOrderSecuritydigestConsumerBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否还有下一页
        /// </summary>
        [JsonProperty("has_next_page")]
        public bool HasNextPage { get; set; }

        /// <summary>
        /// 订单信息列表，当存在符合条件的订单时，则返回订单信息；
        /// </summary>
        [JsonProperty("order_list")]
        public List<AlipayOrderDataOpenapiResultInfo> OrderList { get; set; }
    }
}
