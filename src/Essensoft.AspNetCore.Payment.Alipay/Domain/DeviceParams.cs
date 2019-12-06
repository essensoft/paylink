using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DeviceParams Data Structure.
    /// </summary>
    public class DeviceParams : AlipayObject
    {
        /// <summary>
        /// 设备Id
        /// </summary>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [JsonPropertyName("device_name")]
        public string DeviceName { get; set; }

        /// <summary>
        /// 设备类型，目前有四种值：  VR一体机：VR_MACHINE、电视：TV、身份证：ID_CARD、工牌：WORK_CARD
        /// </summary>
        [JsonPropertyName("device_type")]
        public string DeviceType { get; set; }
    }
}
