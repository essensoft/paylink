using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishVirtualShopSimplifyInfo Data Structure.
    /// </summary>
    public class KbdishVirtualShopSimplifyInfo : AlipayObject
    {
        /// <summary>
        /// 门店下虚拟类目信息
        /// </summary>
        [JsonPropertyName("catetory_list")]
        public List<KbdishVirtualCatetorySimplifyInfo> CatetoryList { get; set; }

        /// <summary>
        /// 外部门店id，和shop_id做为二选一必填
        /// </summary>
        [JsonPropertyName("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 口碑门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
