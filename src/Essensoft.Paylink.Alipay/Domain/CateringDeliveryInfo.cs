using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// CateringDeliveryInfo Data Structure.
    /// </summary>
    public class CateringDeliveryInfo : AlipayObject
    {
        /// <summary>
        /// 骑手位置，单位是米。
        /// </summary>
        [JsonPropertyName("delivery_distance")]
        public string DeliveryDistance { get; set; }

        /// <summary>
        /// 骑手联系方式（必须是虚拟号）
        /// </summary>
        [JsonPropertyName("delivery_mobile")]
        public string DeliveryMobile { get; set; }

        /// <summary>
        /// 配送商信息。配送中及之后状态必填。
        /// </summary>
        [JsonPropertyName("distributor")]
        public string Distributor { get; set; }

        /// <summary>
        /// 预计送达结束时间。如果是时间段，start和end都要填；如果是时间点，填入start。endtime需要大于starttime。
        /// </summary>
        [JsonPropertyName("estimate_delivery_end_time")]
        public string EstimateDeliveryEndTime { get; set; }

        /// <summary>
        /// 预计送达开始时间。如果是时间段，start和end都要填；如果是时间点，填入start。
        /// </summary>
        [JsonPropertyName("estimate_delivery_start_time")]
        public string EstimateDeliveryStartTime { get; set; }
    }
}
