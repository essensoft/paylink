using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DeviceApplyOrderDeviceModel Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceApplyOrderDeviceModel : AlipayObject
    {
        /// <summary>
        /// 设备sn编号
        /// </summary>
        [JsonProperty("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// itemId
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 厂商id
        /// </summary>
        [JsonProperty("supplier_id")]
        public string SupplierId { get; set; }
    }
}
