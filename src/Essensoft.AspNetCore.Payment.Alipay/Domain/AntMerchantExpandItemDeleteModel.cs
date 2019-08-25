using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandItemDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandItemDeleteModel : AlipayObject
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }
    }
}
