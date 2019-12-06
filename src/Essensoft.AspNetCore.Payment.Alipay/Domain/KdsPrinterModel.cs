using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KdsPrinterModel Data Structure.
    /// </summary>
    public class KdsPrinterModel : AlipayObject
    {
        /// <summary>
        /// 打印机设备Id
        /// </summary>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 打印机名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 打印机id
        /// </summary>
        [JsonPropertyName("printer_id")]
        public string PrinterId { get; set; }
    }
}
