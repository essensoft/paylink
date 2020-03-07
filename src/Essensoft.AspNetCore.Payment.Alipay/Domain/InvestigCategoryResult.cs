using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InvestigCategoryResult Data Structure.
    /// </summary>
    public class InvestigCategoryResult : AlipayObject
    {
        /// <summary>
        /// 数据项Category
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// 数据项对应的所有采集结果
        /// </summary>
        [JsonPropertyName("category_result")]
        public List<InvestigCategoryData> CategoryResult { get; set; }
    }
}
