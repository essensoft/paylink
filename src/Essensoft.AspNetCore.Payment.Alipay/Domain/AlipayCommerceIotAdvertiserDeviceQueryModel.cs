using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserDeviceQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotAdvertiserDeviceQueryModel : AlipayObject
    {
        /// <summary>
        /// 设备类型，比如qt 或 pos
        /// </summary>
        [JsonPropertyName("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 20
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }
    }
}
