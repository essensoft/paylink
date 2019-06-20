using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosPaymodeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosPaymodeQueryModel : AlipayObject
    {
        /// <summary>
        /// 门店id
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }
    }
}
