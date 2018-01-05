using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Alipay.Domain;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicSinglearticleDataBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicSinglearticleDataBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 单篇文章分析数据列表
        /// </summary>
        [JsonProperty("data_list")]
        public List<SingleArticleAnalysisData> DataList { get; set; }
    }
}
