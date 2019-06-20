using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandTradeorderEventSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandTradeorderEventSendModel : AlipayObject
    {
        /// <summary>
        /// 物流事件：LOGISTICS_ORDER_PAID(支付成功)、LOGISTICS_ORDER_CANCEL(取消)、COURIER_RECEIVED_ORDER(配送员接单)、COURIER_ARRIVED_SHOP(配送员到店)、COURIER_OBTAINED_GOODS(配送员已取货)、COURIER_ARRIVED_DEST(配送员已到达目的地)、LOGISTICS_ORDER_CONFIRM(确认)
        /// </summary>
        [JsonProperty("event")]
        public string Event { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonProperty("ext_info")]
        public List<OrderExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 订单ID；订单唯一标识
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }
    }
}
