using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniItemBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniItemBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 小程序商品列表
        /// </summary>
        [JsonPropertyName("result_obj")]
        public List<ItemVO> ResultObj { get; set; }
    }
}
