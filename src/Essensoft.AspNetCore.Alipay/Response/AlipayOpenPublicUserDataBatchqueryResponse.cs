using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Alipay.Domain;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicUserDataBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicUserDataBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户分析数据
        /// </summary>
        [JsonProperty("data_list")]
        public List<UserAnalysisData> DataList { get; set; }
    }
}
