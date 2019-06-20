using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DeviceResultInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceResultInfo : AlipayObject
    {
        /// <summary>
        /// 设备id
        /// </summary>
        [JsonProperty("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 业务数据类型
        /// </summary>
        [JsonProperty("device_label")]
        public string DeviceLabel { get; set; }
    }
}
