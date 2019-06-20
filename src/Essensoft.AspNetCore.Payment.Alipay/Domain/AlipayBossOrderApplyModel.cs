using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossOrderApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossOrderApplyModel : AlipayObject
    {
        /// <summary>
        /// synchronize
        /// </summary>
        [JsonProperty("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        [JsonProperty("order_type")]
        public string OrderType { get; set; }
    }
}
