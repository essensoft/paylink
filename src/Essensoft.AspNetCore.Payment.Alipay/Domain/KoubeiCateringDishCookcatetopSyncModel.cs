using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringDishCookcatetopSyncModel Data Structure.
    /// </summary>
    public class KoubeiCateringDishCookcatetopSyncModel : AlipayObject
    {
        /// <summary>
        /// 菜谱类目置顶操作列表，一次批量操作最多100个
        /// </summary>
        [JsonPropertyName("kbdish_cook_cate_top_info_list")]
        public List<KbdishCookCateTopInfo> KbdishCookCateTopInfoList { get; set; }
    }
}
