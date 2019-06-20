using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityProdIfaaDevicepubkeyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdIfaaDevicepubkeyQueryModel : AlipayObject
    {
        /// <summary>
        /// 用于协商ECDH的publickey，base6编码
        /// </summary>
        [JsonProperty("ecdh_publickey")]
        public string EcdhPublickey { get; set; }

        /// <summary>
        /// 已返回记录的最大ID，初次请求输入0
        /// </summary>
        [JsonProperty("max_id")]
        public string MaxId { get; set; }

        /// <summary>
        /// 安全设备的ID。
        /// </summary>
        [JsonProperty("security_device_id")]
        public string SecurityDeviceId { get; set; }

        /// <summary>
        /// 安全设备类型，SGX或者加密机
        /// </summary>
        [JsonProperty("security_schema")]
        public string SecuritySchema { get; set; }
    }
}
