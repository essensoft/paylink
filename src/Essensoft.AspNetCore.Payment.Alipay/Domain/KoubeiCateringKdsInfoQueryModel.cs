using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringKdsInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringKdsInfoQueryModel : AlipayObject
    {
        /// <summary>
        /// kdsID
        /// </summary>
        [JsonProperty("kds_id")]
        public string KdsId { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }
    }
}
