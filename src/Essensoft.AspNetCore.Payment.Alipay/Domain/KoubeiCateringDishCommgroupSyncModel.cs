using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringDishCommgroupSyncModel Data Structure.
    /// </summary>
    public class KoubeiCateringDishCommgroupSyncModel : AlipayObject
    {
        /// <summary>
        /// group：组信息；detail：明细信息
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 组模型
        /// </summary>
        [JsonPropertyName("kbdish_comm_group_info")]
        public KbdishCommGroupInfo KbdishCommGroupInfo { get; set; }

        /// <summary>
        /// 同步类型: add 新增;update 修改;del 删除
        /// </summary>
        [JsonPropertyName("syn_type")]
        public string SynType { get; set; }
    }
}
