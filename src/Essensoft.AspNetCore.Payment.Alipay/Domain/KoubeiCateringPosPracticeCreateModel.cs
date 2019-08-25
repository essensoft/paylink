using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosPracticeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosPracticeCreateModel : AlipayObject
    {
        /// <summary>
        /// 做法名称
        /// </summary>
        [JsonProperty("practice_name")]
        public string PracticeName { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }
    }
}
