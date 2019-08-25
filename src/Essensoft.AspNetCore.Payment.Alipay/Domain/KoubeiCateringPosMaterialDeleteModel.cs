using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosMaterialDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosMaterialDeleteModel : AlipayObject
    {
        /// <summary>
        /// 配料id
        /// </summary>
        [JsonProperty("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }
    }
}
