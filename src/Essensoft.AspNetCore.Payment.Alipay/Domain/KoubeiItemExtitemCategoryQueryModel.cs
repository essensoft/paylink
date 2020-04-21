using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiItemExtitemCategoryQueryModel Data Structure.
    /// </summary>
    public class KoubeiItemExtitemCategoryQueryModel : AlipayObject
    {
        /// <summary>
        /// 父品类编码. (查询顶级类目时值传0)
        /// </summary>
        [JsonPropertyName("parent_id")]
        public string ParentId { get; set; }
    }
}
