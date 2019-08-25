using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiSalesKbassetStuffOrdersresultSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiSalesKbassetStuffOrdersresultSyncModel : AlipayObject
    {
        /// <summary>
        /// 物料单据反馈列表，最大200条
        /// </summary>
        [JsonProperty("orders_feedback")]
        public List<AccessOrdersFeedBack> OrdersFeedback { get; set; }
    }
}
