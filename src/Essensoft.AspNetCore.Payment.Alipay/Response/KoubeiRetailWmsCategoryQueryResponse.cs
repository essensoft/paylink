using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiRetailWmsCategoryQueryResponse.
    /// </summary>
    public class KoubeiRetailWmsCategoryQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 类目信息
        /// </summary>
        [JsonPropertyName("category")]
        public CategoryVO Category { get; set; }

        /// <summary>
        /// 子类目信息
        /// </summary>
        [JsonPropertyName("sub_categories")]
        public List<CategoryVO> SubCategories { get; set; }
    }
}
