using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RefundInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RefundInfo : AlipayObject
    {
        /// <summary>
        /// 退款金额
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 商品单ID
        /// </summary>
        [JsonProperty("item_order_no")]
        public string ItemOrderNo { get; set; }
    }
}
