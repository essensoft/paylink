using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerbaseinfoCategorytreeQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerbaseinfoCategorytreeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 小程序一级类目列表
        /// </summary>
        [JsonPropertyName("category_list")]
        public List<MiniAppFirstCategoryInfo> CategoryList { get; set; }
    }
}
