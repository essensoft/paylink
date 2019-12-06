using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiSalesKbassetStuffOrdersresultSyncModel Data Structure.
    /// </summary>
    public class KoubeiSalesKbassetStuffOrdersresultSyncModel : AlipayObject
    {
        /// <summary>
        /// 物料单据反馈列表，最大200条
        /// </summary>
        [JsonPropertyName("orders_feedback")]
        public List<AccessOrdersFeedBack> OrdersFeedback { get; set; }
    }
}
