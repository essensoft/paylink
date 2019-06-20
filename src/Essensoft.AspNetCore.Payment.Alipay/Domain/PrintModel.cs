using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PrintModel Data Structure.
    /// </summary>
    [Serializable]
    public class PrintModel : AlipayObject
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        [JsonProperty("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        [JsonProperty("enable")]
        public bool Enable { get; set; }

        /// <summary>
        /// 打印机名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 打印机id
        /// </summary>
        [JsonProperty("printer_id")]
        public long PrinterId { get; set; }

        /// <summary>
        /// 打印机类型（FRONT_DESK_PRINTER：前台打印机；LABEL_PRINTER：标签打印机；KITCHEN_PRINTER：厨房打印机）
        /// </summary>
        [JsonProperty("printer_type")]
        public string PrinterType { get; set; }
    }
}
