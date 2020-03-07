using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingPassShopBindModel Data Structure.
    /// </summary>
    public class AlipayMarketingPassShopBindModel : AlipayObject
    {
        /// <summary>
        /// 当前操作是否为追加门店绑定，默认为true，代表为追加门店绑定，现有的门店列表不变，追加绑定本次传入的门店列表；  传值为false时，则为覆盖更新，先删除现有的门店列表，再绑定本次传入的门店列表；
        /// </summary>
        [JsonPropertyName("is_appending")]
        public bool IsAppending { get; set; }

        /// <summary>
        /// 门店ID列表，1次请求最多传入500家门店，超过请设置is_appending为true分批传入绑定；  注意：若不传门店列表且is_appending为false，则表示清空当前绑定门店列表。
        /// </summary>
        [JsonPropertyName("shop_list")]
        public List<string> ShopList { get; set; }

        /// <summary>
        /// 模板ID（编号），创建模板接口返回的模板ID
        /// </summary>
        [JsonPropertyName("tpl_id")]
        public string TplId { get; set; }
    }
}
