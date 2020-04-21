using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DeviceApplyOrderItemModel Data Structure.
    /// </summary>
    public class DeviceApplyOrderItemModel : AlipayObject
    {
        /// <summary>
        /// 申请数量，和sn数量保持一致
        /// </summary>
        [JsonPropertyName("apply_amount")]
        public long ApplyAmount { get; set; }

        /// <summary>
        /// 设备编号
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 设备型号
        /// </summary>
        [JsonPropertyName("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 设备型号
        /// </summary>
        [JsonPropertyName("model_number")]
        public string ModelNumber { get; set; }
    }
}
