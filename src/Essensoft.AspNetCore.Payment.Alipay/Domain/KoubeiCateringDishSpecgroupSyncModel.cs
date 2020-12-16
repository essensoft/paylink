using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringDishSpecgroupSyncModel Data Structure.
    /// </summary>
    public class KoubeiCateringDishSpecgroupSyncModel : AlipayObject
    {
        /// <summary>
        /// 创建者
        /// </summary>
        [JsonPropertyName("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 规格标签
        /// </summary>
        [JsonPropertyName("kbdish_spec_group")]
        public KbdishSpecGroup KbdishSpecGroup { get; set; }

        /// <summary>
        /// 同步类型: add 新增,del 删除,update 更新
        /// </summary>
        [JsonPropertyName("syn_type")]
        public string SynType { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [JsonPropertyName("update_user")]
        public string UpdateUser { get; set; }
    }
}
