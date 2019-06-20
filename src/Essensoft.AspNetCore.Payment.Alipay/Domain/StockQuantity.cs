using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StockQuantity Data Structure.
    /// </summary>
    [Serializable]
    public class StockQuantity : AlipayObject
    {
        /// <summary>
        /// 日期
        /// </summary>
        [JsonProperty("date")]
        public string Date { get; set; }

        /// <summary>
        /// 库存量
        /// </summary>
        [JsonProperty("quantity")]
        public long Quantity { get; set; }
    }
}
