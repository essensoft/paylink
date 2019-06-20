using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DeviceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceInfo : AlipayObject
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        [JsonProperty("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [JsonProperty("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 设备sn编号
        /// </summary>
        [JsonProperty("dv_sn")]
        public string DvSn { get; set; }

        /// <summary>
        /// 生产厂商
        /// </summary>
        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }

        /// <summary>
        /// 产品型号
        /// </summary>
        [JsonProperty("product_model")]
        public string ProductModel { get; set; }
    }
}
