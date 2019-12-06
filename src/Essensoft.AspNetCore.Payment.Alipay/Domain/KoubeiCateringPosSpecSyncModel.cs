using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosSpecSyncModel Data Structure.
    /// </summary>
    public class KoubeiCateringPosSpecSyncModel : AlipayObject
    {
        /// <summary>
        /// 菜品规格信息
        /// </summary>
        [JsonPropertyName("spec")]
        public SpecEntity Spec { get; set; }

        /// <summary>
        /// 规格ids,删除时传
        /// </summary>
        [JsonPropertyName("spec_ids")]
        public List<string> SpecIds { get; set; }

        /// <summary>
        /// 操作类型 add 新增，update 修改，del 删除 ，其他返回null
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
