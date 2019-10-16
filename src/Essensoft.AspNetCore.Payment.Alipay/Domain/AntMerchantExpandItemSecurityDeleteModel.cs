using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandItemSecurityDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandItemSecurityDeleteModel : AlipayObject
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }
    }
}
