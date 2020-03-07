using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdIfaaDevicepubkeyQueryResponse.
    /// </summary>
    public class AlipaySecurityProdIfaaDevicepubkeyQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 加密过的设备公钥信息。
        /// </summary>
        [JsonPropertyName("device_key_info")]
        public string DeviceKeyInfo { get; set; }
    }
}
