using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniAmpeCategoryBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniAmpeCategoryBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 可选行业列表
        /// </summary>
        [JsonPropertyName("category_list")]
        public List<AmpeCategoryInfo> CategoryList { get; set; }
    }
}
