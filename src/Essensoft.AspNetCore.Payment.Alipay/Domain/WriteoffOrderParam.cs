using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// WriteoffOrderParam Data Structure.
    /// </summary>
    [Serializable]
    public class WriteoffOrderParam : AlipayObject
    {
        /// <summary>
        /// 当前子订单是否已结清
        /// </summary>
        [JsonProperty("is_clearance")]
        public bool IsClearance { get; set; }

        /// <summary>
        /// 主订单号
        /// </summary>
        [JsonProperty("order_num")]
        public string OrderNum { get; set; }

        /// <summary>
        /// 子订单号
        /// </summary>
        [JsonProperty("sub_order_num")]
        public string SubOrderNum { get; set; }
    }
}
