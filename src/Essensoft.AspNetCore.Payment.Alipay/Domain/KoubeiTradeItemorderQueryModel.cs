using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiTradeItemorderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiTradeItemorderQueryModel : AlipayObject
    {
        /// <summary>
        /// 口碑订单号
        /// </summary>
        [JsonProperty("order_no")]
        public string OrderNo { get; set; }
    }
}
