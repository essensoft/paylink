using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandFrontcategorySecurityModifyModel Data Structure.
    /// </summary>
    public class AntMerchantExpandFrontcategorySecurityModifyModel : AlipayObject
    {
        /// <summary>
        /// 前台类目描述
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 前台类目ID
        /// </summary>
        [JsonPropertyName("front_category_id")]
        public string FrontCategoryId { get; set; }

        /// <summary>
        /// 素材列表（会和前台类目已存在素材做差异化比较后做增删改操作）
        /// </summary>
        [JsonPropertyName("material_list")]
        public List<MaterialModifyInfo> MaterialList { get; set; }

        /// <summary>
        /// 前台类目名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
