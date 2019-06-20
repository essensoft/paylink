using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosMaterialModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosMaterialModifyModel : AlipayObject
    {
        /// <summary>
        /// 配料id
        /// </summary>
        [JsonProperty("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 配料名称
        /// </summary>
        [JsonProperty("material_name")]
        public string MaterialName { get; set; }

        /// <summary>
        /// 售价
        /// </summary>
        [JsonProperty("sell_price")]
        public string SellPrice { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }
    }
}
