using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosCategoryModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosCategoryModifyModel : AlipayObject
    {
        /// <summary>
        /// 类别ID
        /// </summary>
        [JsonProperty("cate_id")]
        public string CateId { get; set; }

        /// <summary>
        /// 菜类名称
        /// </summary>
        [JsonProperty("cate_name")]
        public string CateName { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }
    }
}
