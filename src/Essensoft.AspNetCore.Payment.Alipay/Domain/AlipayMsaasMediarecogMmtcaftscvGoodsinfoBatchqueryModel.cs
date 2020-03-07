using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvGoodsinfoBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayMsaasMediarecogMmtcaftscvGoodsinfoBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 算法id列表
        /// </summary>
        [JsonPropertyName("algorithm_ids")]
        public List<string> AlgorithmIds { get; set; }
    }
}
