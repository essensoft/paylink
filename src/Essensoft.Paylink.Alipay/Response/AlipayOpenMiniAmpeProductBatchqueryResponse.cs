using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniAmpeProductBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniAmpeProductBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户设备产品列表
        /// </summary>
        [JsonPropertyName("product_list")]
        public List<AmpeProductInfo> ProductList { get; set; }
    }
}
