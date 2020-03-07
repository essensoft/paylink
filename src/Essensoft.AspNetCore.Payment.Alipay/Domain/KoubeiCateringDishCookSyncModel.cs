using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringDishCookSyncModel Data Structure.
    /// </summary>
    public class KoubeiCateringDishCookSyncModel : AlipayObject
    {
        /// <summary>
        /// cook：操作菜谱信息 ; shop:全量覆盖门店; detail;操作菜谱明细以及价格
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 口碑菜谱
        /// </summary>
        [JsonPropertyName("kb_dish_cook")]
        public KbdishCookInfo KbDishCook { get; set; }

        /// <summary>
        /// 同步类型: add 新增;update 修改;stateChange 状态变更,del 删除
        /// </summary>
        [JsonPropertyName("syn_type")]
        public string SynType { get; set; }
    }
}
