using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandDeliveryLogisticsSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandDeliveryLogisticsSyncModel : AlipayObject
    {
        /// <summary>
        /// 配送指令
        /// </summary>
        [JsonProperty("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 物流信息
        /// </summary>
        [JsonProperty("logistics_info")]
        public LogisticsInfo LogisticsInfo { get; set; }
    }
}
