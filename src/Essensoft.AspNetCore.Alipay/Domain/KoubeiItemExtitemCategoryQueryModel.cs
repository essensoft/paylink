using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// KoubeiItemExtitemCategoryQueryModel Data Structure.
    /// </summary>
    public class KoubeiItemExtitemCategoryQueryModel : AlipayObject
    {
        /// <summary>
        /// 父品类编码. (查询顶级类目时值传0)
        /// </summary>
        [JsonProperty("parent_id")]
        public string ParentId { get; set; }
    }
}
