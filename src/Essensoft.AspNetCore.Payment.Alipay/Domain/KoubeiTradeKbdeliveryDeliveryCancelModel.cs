using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiTradeKbdeliveryDeliveryCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiTradeKbdeliveryDeliveryCancelModel : AlipayObject
    {
        /// <summary>
        /// 口碑物流单，单号；  需要撤销的单据号
        /// </summary>
        [JsonProperty("logistics_order_no")]
        public string LogisticsOrderNo { get; set; }

        /// <summary>
        /// 关闭物流订单原因
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
