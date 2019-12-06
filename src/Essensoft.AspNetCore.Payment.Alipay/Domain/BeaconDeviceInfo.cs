using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BeaconDeviceInfo Data Structure.
    /// </summary>
    public class BeaconDeviceInfo : AlipayObject
    {
        /// <summary>
        /// 设备类型
        /// </summary>
        [JsonPropertyName("actiontype")]
        public string Actiontype { get; set; }

        /// <summary>
        /// 设备是否可用
        /// </summary>
        [JsonPropertyName("inuse")]
        public bool Inuse { get; set; }

        /// <summary>
        /// 设备说明
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 设备序列号
        /// </summary>
        [JsonPropertyName("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 蓝牙设备关联的模板信息
        /// </summary>
        [JsonPropertyName("template")]
        public BeaconTemplate Template { get; set; }

        /// <summary>
        /// 设备ID
        /// </summary>
        [JsonPropertyName("uuid")]
        public string Uuid { get; set; }
    }
}
