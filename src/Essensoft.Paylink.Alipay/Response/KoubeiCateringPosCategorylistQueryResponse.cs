using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringPosCategorylistQueryResponse.
    /// </summary>
    public class KoubeiCateringPosCategorylistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 菜类列表
        /// </summary>
        [JsonPropertyName("category_entity_list")]
        public List<DishCategoryEntity> CategoryEntityList { get; set; }
    }
}
