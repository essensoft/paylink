using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiRetailWmsGoodsBatchqueryResponse.
    /// </summary>
    public class KoubeiRetailWmsGoodsBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 货品信息
        /// </summary>
        [JsonPropertyName("goods")]
        public List<GoodsVO> Goods { get; set; }

        /// <summary>
        /// 记录总数
        /// </summary>
        [JsonPropertyName("total_count")]
        public string TotalCount { get; set; }
    }
}
