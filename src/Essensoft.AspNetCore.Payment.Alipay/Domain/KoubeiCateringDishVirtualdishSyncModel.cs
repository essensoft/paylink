using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringDishVirtualdishSyncModel Data Structure.
    /// </summary>
    public class KoubeiCateringDishVirtualdishSyncModel : AlipayObject
    {
        /// <summary>
        /// 创建人
        /// </summary>
        [JsonPropertyName("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 虚拟分类菜设置
        /// </summary>
        [JsonPropertyName("kbdish_virtual_dish_info_list")]
        public List<KbVirtualShopInfo> KbdishVirtualDishInfoList { get; set; }

        /// <summary>
        /// 更新人
        /// </summary>
        [JsonPropertyName("update_user")]
        public string UpdateUser { get; set; }
    }
}
