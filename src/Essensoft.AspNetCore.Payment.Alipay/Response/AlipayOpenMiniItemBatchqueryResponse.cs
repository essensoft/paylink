using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
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
