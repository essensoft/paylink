using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenDataItemRecommendBatchqueryResponse.
    /// </summary>
    public class AlipayOpenDataItemRecommendBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 推荐结果
        /// </summary>
        [JsonPropertyName("result_obj")]
        public List<RecResultInfo> ResultObj { get; set; }
    }
}
