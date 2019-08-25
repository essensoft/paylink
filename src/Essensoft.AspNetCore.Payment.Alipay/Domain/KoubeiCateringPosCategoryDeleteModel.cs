using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosCategoryDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosCategoryDeleteModel : AlipayObject
    {
        /// <summary>
        /// 菜类ID
        /// </summary>
        [JsonProperty("cate_id")]
        public string CateId { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }
    }
}
