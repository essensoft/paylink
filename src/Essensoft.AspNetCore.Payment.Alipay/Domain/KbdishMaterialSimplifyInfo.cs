using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishMaterialSimplifyInfo Data Structure.
    /// </summary>
    public class KbdishMaterialSimplifyInfo : AlipayObject
    {
        /// <summary>
        /// 加料id列表，加料先通过加料创建接口拿到id
        /// </summary>
        [JsonPropertyName("material_detail_list")]
        public List<string> MaterialDetailList { get; set; }

        /// <summary>
        /// 加料组规格，max_count：最大可选数量，min_count：最小可选数量
        /// </summary>
        [JsonPropertyName("material_rule")]
        public string MaterialRule { get; set; }

        /// <summary>
        /// 加料组名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
