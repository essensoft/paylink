using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AdCreative Data Structure.
    /// </summary>
    public class AdCreative : AlipayObject
    {
        /// <summary>
        /// 广告物料包含的物料列表
        /// </summary>
        [JsonPropertyName("ad_material_list")]
        public List<AdMaterial> AdMaterialList { get; set; }

        /// <summary>
        /// 创意名称
        /// </summary>
        [JsonPropertyName("ad_name")]
        public string AdName { get; set; }

        /// <summary>
        /// 所属广告单元ID
        /// </summary>
        [JsonPropertyName("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 创意使用模板ID
        /// </summary>
        [JsonPropertyName("template_id")]
        public long TemplateId { get; set; }
    }
}
