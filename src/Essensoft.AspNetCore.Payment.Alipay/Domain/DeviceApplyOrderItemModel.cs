using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DeviceApplyOrderItemModel Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceApplyOrderItemModel : AlipayObject
    {
        /// <summary>
        /// 申请数量，和sn数量保持一致
        /// </summary>
        [JsonProperty("apply_amount")]
        public long ApplyAmount { get; set; }

        /// <summary>
        /// 设备编号
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 设备型号
        /// </summary>
        [JsonProperty("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 设备型号
        /// </summary>
        [JsonProperty("model_number")]
        public string ModelNumber { get; set; }
    }
}
