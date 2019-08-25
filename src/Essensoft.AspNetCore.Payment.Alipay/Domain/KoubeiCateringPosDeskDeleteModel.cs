using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosDeskDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosDeskDeleteModel : AlipayObject
    {
        /// <summary>
        /// 桌位Id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 门店Id
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }
    }
}
