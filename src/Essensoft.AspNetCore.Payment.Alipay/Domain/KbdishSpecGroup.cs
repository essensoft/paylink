using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishSpecGroup Data Structure.
    /// </summary>
    public class KbdishSpecGroup : AlipayObject
    {
        /// <summary>
        /// 规格标签明细
        /// </summary>
        [JsonPropertyName("spec_detail_list")]
        public List<KbdishSpecGroupDetail> SpecDetailList { get; set; }

        /// <summary>
        /// 规格组id, 热组 冷组 去冰组
        /// </summary>
        [JsonPropertyName("spec_id")]
        public string SpecId { get; set; }

        /// <summary>
        /// 规格组的名称
        /// </summary>
        [JsonPropertyName("spec_name")]
        public string SpecName { get; set; }
    }
}
