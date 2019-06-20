using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicArticlesummaryDataBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicArticlesummaryDataBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 文章分析数据列表
        /// </summary>
        [JsonProperty("data_list")]
        public List<ArticleSummaryAnalysisData> DataList { get; set; }
    }
}
