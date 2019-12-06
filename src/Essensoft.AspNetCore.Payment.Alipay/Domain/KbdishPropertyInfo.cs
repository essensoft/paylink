using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishPropertyInfo Data Structure.
    /// </summary>
    public class KbdishPropertyInfo : AlipayObject
    {
        /// <summary>
        /// “属性最多可选数”，默认为1，与“属性最少可选数”同时为空或同时非空，不能为0，数值不能大于销售属性值的数量，即property_value_info_list的长度
        /// </summary>
        [JsonPropertyName("max_count_limit")]
        public string MaxCountLimit { get; set; }

        /// <summary>
        /// “属性最少可选数”，默认为1，与“属性最多可选数”同时为空或同时非空，不能为0，数值不能大于“属性最多可选数”
        /// </summary>
        [JsonPropertyName("min_count_limit")]
        public string MinCountLimit { get; set; }

        /// <summary>
        /// 菜品属性名称
        /// </summary>
        [JsonPropertyName("property_name")]
        public string PropertyName { get; set; }

        /// <summary>
        /// 菜品销售属性属性值模型
        /// </summary>
        [JsonPropertyName("property_value_info_list")]
        public List<KbdishPropertyValueInfo> PropertyValueInfoList { get; set; }

        /// <summary>
        /// 菜品属性排序字段，从1一直递增到4
        /// </summary>
        [JsonPropertyName("sort")]
        public string Sort { get; set; }
    }
}
