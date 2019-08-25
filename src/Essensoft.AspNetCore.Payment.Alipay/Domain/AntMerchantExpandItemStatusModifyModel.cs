using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandItemStatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandItemStatusModifyModel : AlipayObject
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品状态：EFFECT、INVALID
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
