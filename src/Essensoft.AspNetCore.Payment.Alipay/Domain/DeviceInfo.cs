using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DeviceInfo Data Structure.
    /// </summary>
    public class DeviceInfo : AlipayObject
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [JsonPropertyName("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 设备sn编号
        /// </summary>
        [JsonPropertyName("dv_sn")]
        public string DvSn { get; set; }

        /// <summary>
        /// 生产厂商
        /// </summary>
        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }

        /// <summary>
        /// 产品型号
        /// </summary>
        [JsonPropertyName("product_model")]
        public string ProductModel { get; set; }
    }
}
