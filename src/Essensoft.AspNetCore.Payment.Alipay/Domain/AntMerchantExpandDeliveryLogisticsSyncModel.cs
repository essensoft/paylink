using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandDeliveryLogisticsSyncModel Data Structure.
    /// </summary>
    public class AntMerchantExpandDeliveryLogisticsSyncModel : AlipayObject
    {
        /// <summary>
        /// 配送指令
        /// </summary>
        [JsonPropertyName("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 物流信息
        /// </summary>
        [JsonPropertyName("logistics_info")]
        public LogisticsInfo LogisticsInfo { get; set; }
    }
}
