using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailItemQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailItemQueryModel : AlipayObject
    {
        /// <summary>
        /// 城市编码，6位国际码
        /// </summary>
        [JsonProperty("city_id")]
        public string CityId { get; set; }

        /// <summary>
        /// 支付宝商品ID，即展示的券
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }
    }
}
