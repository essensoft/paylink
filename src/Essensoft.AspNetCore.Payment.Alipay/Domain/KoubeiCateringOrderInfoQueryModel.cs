using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringOrderInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringOrderInfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 订单ID
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }
    }
}
