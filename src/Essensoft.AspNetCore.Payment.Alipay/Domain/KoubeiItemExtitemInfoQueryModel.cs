using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiItemExtitemInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiItemExtitemInfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 商品编码
        /// </summary>
        [JsonProperty("goods_id")]
        public string GoodsId { get; set; }
    }
}
