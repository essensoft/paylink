using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
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
