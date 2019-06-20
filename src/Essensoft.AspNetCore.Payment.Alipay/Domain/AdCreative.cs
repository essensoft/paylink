using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AdCreative Data Structure.
    /// </summary>
    [Serializable]
    public class AdCreative : AlipayObject
    {
        /// <summary>
        /// 广告物料包含的物料列表
        /// </summary>
        [JsonProperty("ad_material_list")]
        public List<AdMaterial> AdMaterialList { get; set; }

        /// <summary>
        /// 创意名称
        /// </summary>
        [JsonProperty("ad_name")]
        public string AdName { get; set; }

        /// <summary>
        /// 所属广告单元ID
        /// </summary>
        [JsonProperty("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 创意使用模板ID
        /// </summary>
        [JsonProperty("template_id")]
        public long TemplateId { get; set; }
    }
}
