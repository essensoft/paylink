using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KdsPrinterModel Data Structure.
    /// </summary>
    [Serializable]
    public class KdsPrinterModel : AlipayObject
    {
        /// <summary>
        /// 打印机设备Id
        /// </summary>
        [JsonProperty("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 打印机名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 打印机id
        /// </summary>
        [JsonProperty("printer_id")]
        public string PrinterId { get; set; }
    }
}
