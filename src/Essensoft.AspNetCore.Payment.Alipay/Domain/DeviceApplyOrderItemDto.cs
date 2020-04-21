using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DeviceApplyOrderItemDto Data Structure.
    /// </summary>
    public class DeviceApplyOrderItemDto : AlipayObject
    {
        /// <summary>
        /// 申请数量，和sn数量保持一致
        /// </summary>
        [JsonPropertyName("apply_amount")]
        public long ApplyAmount { get; set; }

        /// <summary>
        /// itemId
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

        /// <summary>
        /// sn列表
        /// </summary>
        [JsonPropertyName("sn_list")]
        public List<string> SnList { get; set; }

        /// <summary>
        /// 厂商id
        /// </summary>
        [JsonPropertyName("supplier_id")]
        public string SupplierId { get; set; }
    }
}
