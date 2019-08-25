using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMallScanpurchaseUserpreorderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMallScanpurchaseUserpreorderQueryModel : AlipayObject
    {
        /// <summary>
        /// 预订单编号
        /// </summary>
        [JsonProperty("advance_order_id")]
        public string AdvanceOrderId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
