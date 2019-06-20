using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiShopMallCardQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiShopMallCardQueryModel : AlipayObject
    {
        /// <summary>
        /// 商圈ID
        /// </summary>
        [JsonProperty("mall_id")]
        public string MallId { get; set; }
    }
}
