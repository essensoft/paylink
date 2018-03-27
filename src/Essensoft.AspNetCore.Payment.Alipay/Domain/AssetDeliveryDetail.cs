using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AssetDeliveryDetail Data Structure.
    /// </summary>
    public class AssetDeliveryDetail : AlipayObject
    {
        /// <summary>
        /// 配送数量
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 配送订单ID
        /// </summary>
        [JsonProperty("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 物流单信息
        /// </summary>
        [JsonProperty("logistics_infos")]
        public List<LogisticsInfo> LogisticsInfos { get; set; }
    }
}
