using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishSkuSimplifyInfo Data Structure.
    /// </summary>
    public class KbdishSkuSimplifyInfo : AlipayObject
    {
        /// <summary>
        /// 加料组列表
        /// </summary>
        [JsonPropertyName("material_group_list")]
        public List<KbdishMaterialSimplifyInfo> MaterialGroupList { get; set; }

        /// <summary>
        /// 外部skuId
        /// </summary>
        [JsonPropertyName("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// 规格1组名称
        /// </summary>
        [JsonPropertyName("spec_01_group_name")]
        public string Spec01GroupName { get; set; }

        /// <summary>
        /// 规格1的id
        /// </summary>
        [JsonPropertyName("spec_01_id")]
        public string Spec01Id { get; set; }

        /// <summary>
        /// 规格1名称
        /// </summary>
        [JsonPropertyName("spec_01_name")]
        public string Spec01Name { get; set; }

        /// <summary>
        /// 规格1排序值
        /// </summary>
        [JsonPropertyName("spec_01_sort")]
        public string Spec01Sort { get; set; }

        /// <summary>
        /// 规格2组名称
        /// </summary>
        [JsonPropertyName("spec_02_group_name")]
        public string Spec02GroupName { get; set; }

        /// <summary>
        /// 规格2的id
        /// </summary>
        [JsonPropertyName("spec_02_id")]
        public string Spec02Id { get; set; }

        /// <summary>
        /// 规格2的名称
        /// </summary>
        [JsonPropertyName("spec_02_name")]
        public string Spec02Name { get; set; }

        /// <summary>
        /// 规格2的排序值
        /// </summary>
        [JsonPropertyName("spec_02_sort")]
        public string Spec02Sort { get; set; }
    }
}
