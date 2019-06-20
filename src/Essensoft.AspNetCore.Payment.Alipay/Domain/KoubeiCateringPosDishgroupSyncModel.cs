using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosDishgroupSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosDishgroupSyncModel : AlipayObject
    {
        /// <summary>
        /// 组合菜详情
        /// </summary>
        [JsonProperty("pos_dish_group_model")]
        public PosDishGroupModel PosDishGroupModel { get; set; }
    }
}
