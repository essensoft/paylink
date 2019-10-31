using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandItemOpenDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandItemOpenDeleteModel : AlipayObject
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }
    }
}
