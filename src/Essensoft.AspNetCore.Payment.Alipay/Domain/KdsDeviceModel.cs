using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KdsDeviceModel Data Structure.
    /// </summary>
    [Serializable]
    public class KdsDeviceModel : AlipayObject
    {
        /// <summary>
        /// 设备编号
        /// </summary>
        [JsonProperty("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 设备sn号
        /// </summary>
        [JsonProperty("sn_id")]
        public string SnId { get; set; }
    }
}
