using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BeaconDeviceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BeaconDeviceInfo : AlipayObject
    {
        /// <summary>
        /// 设备类型
        /// </summary>
        [JsonProperty("actiontype")]
        public string Actiontype { get; set; }

        /// <summary>
        /// 设备是否可用
        /// </summary>
        [JsonProperty("inuse")]
        public bool Inuse { get; set; }

        /// <summary>
        /// 设备说明
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 设备序列号
        /// </summary>
        [JsonProperty("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 蓝牙设备关联的模板信息
        /// </summary>
        [JsonProperty("template")]
        public BeaconTemplate Template { get; set; }

        /// <summary>
        /// 设备ID
        /// </summary>
        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }
}
