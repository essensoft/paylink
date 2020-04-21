using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiRetailWmsGoodsQueryResponse.
    /// </summary>
    public class KoubeiRetailWmsGoodsQueryResponse : AlipayResponse
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
        public long TotalCount { get; set; }
    }
}
