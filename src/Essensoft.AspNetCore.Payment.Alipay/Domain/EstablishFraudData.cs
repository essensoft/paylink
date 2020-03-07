using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EstablishFraudData Data Structure.
    /// </summary>
    public class EstablishFraudData : AlipayObject
    {
        /// <summary>
        /// Wallet所在设备的设备id映射的uuid。
        /// </summary>
        [JsonPropertyName("device_identifier")]
        public string DeviceIdentifier { get; set; }

        /// <summary>
        /// 生物核身是否可获取。 true if device is capable of biometric authentication, otherwise false
        /// </summary>
        [JsonPropertyName("is_biometric_capable")]
        public string IsBiometricCapable { get; set; }

        /// <summary>
        /// Wallet登录icloud账户id映射的uuid。
        /// </summary>
        [JsonPropertyName("user_identifier")]
        public string UserIdentifier { get; set; }
    }
}
