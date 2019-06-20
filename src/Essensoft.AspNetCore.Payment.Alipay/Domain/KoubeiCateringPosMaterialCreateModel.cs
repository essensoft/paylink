using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosMaterialCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosMaterialCreateModel : AlipayObject
    {
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
        /// 商户门店id
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }
    }
}
