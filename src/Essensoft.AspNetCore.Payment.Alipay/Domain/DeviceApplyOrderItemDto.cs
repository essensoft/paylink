using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DeviceApplyOrderItemDto Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceApplyOrderItemDto : AlipayObject
    {
        /// <summary>
        /// 申请数量，和sn数量保持一致
        /// </summary>
        [JsonProperty("apply_amount")]
        public long ApplyAmount { get; set; }

        /// <summary>
        /// itemId
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

        /// <summary>
        /// sn列表
        /// </summary>
        [JsonProperty("sn_list")]
        public List<string> SnList { get; set; }

        /// <summary>
        /// 厂商id
        /// </summary>
        [JsonProperty("supplier_id")]
        public string SupplierId { get; set; }
    }
}
