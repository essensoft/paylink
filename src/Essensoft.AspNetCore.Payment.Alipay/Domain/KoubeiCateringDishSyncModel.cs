using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringDishSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringDishSyncModel : AlipayObject
    {
        /// <summary>
        /// dish：操作菜品模型 ;sku:操作关联sku
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 口碑菜品模型
        /// </summary>
        [JsonProperty("kb_dish_info")]
        public KbdishInfo KbDishInfo { get; set; }

        /// <summary>
        /// 同步类型: add 新增;update 修改;stateChange 状态变更,del 删除
        /// </summary>
        [JsonProperty("syn_type")]
        public string SynType { get; set; }
    }
}
