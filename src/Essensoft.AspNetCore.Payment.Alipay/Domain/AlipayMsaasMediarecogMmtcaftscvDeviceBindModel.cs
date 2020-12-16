using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvDeviceBindModel Data Structure.
    /// </summary>
    public class AlipayMsaasMediarecogMmtcaftscvDeviceBindModel : AlipayObject
    {
        /// <summary>
        /// IOT统一设备id
        /// </summary>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备所属商户pid
        /// </summary>
        [JsonPropertyName("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 商户设备terminal id
        /// </summary>
        [JsonPropertyName("isv_tid")]
        public string IsvTid { get; set; }
    }
}
