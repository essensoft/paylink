using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOfflineProviderEquipmentAuthRemoveResponse.
    /// </summary>
    public class AlipayOfflineProviderEquipmentAuthRemoveResponse : AlipayResponse
    {
        /// <summary>
        /// 被解绑的机具编号
        /// </summary>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 机具厂商PID
        /// </summary>
        [JsonPropertyName("merchant_pid")]
        public string MerchantPid { get; set; }
    }
}
