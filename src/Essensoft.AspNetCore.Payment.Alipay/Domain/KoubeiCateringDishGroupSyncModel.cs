using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringDishGroupSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringDishGroupSyncModel : AlipayObject
    {
        /// <summary>
        /// 口碑菜品套餐项目组
        /// </summary>
        [JsonProperty("kb_dish_group")]
        public KbdishGroupInfo KbDishGroup { get; set; }

        /// <summary>
        /// 同步类型: add 新增;update 修改;stateChange 状态变更,del 删除
        /// </summary>
        [JsonProperty("syn_type")]
        public string SynType { get; set; }
    }
}
