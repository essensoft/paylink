using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniCategoryQueryResponse.
    /// </summary>
    public class AlipayOpenMiniCategoryQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 小程序类目列表
        /// </summary>
        [JsonPropertyName("category_list")]
        public List<MiniAppCategory> CategoryList { get; set; }
    }
}
