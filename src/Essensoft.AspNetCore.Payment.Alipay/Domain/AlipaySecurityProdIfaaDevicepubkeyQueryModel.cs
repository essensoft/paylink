using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityProdIfaaDevicepubkeyQueryModel Data Structure.
    /// </summary>
    public class AlipaySecurityProdIfaaDevicepubkeyQueryModel : AlipayObject
    {
        /// <summary>
        /// 用于协商ECDH的publickey，base6编码
        /// </summary>
        [JsonPropertyName("ecdh_publickey")]
        public string EcdhPublickey { get; set; }

        /// <summary>
        /// 已返回记录的最大ID，初次请求输入0
        /// </summary>
        [JsonPropertyName("max_id")]
        public string MaxId { get; set; }

        /// <summary>
        /// 安全设备的ID。
        /// </summary>
        [JsonPropertyName("security_device_id")]
        public string SecurityDeviceId { get; set; }

        /// <summary>
        /// 安全设备类型，SGX或者加密机
        /// </summary>
        [JsonPropertyName("security_schema")]
        public string SecuritySchema { get; set; }
    }
}
