using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityProdFingerprintRiskcontrolQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdFingerprintRiskcontrolQueryModel : AlipayObject
    {
        /// <summary>
        /// aaid:指纹SDK获取到的aaid，与设备密钥一一对应，为IFAA定义的一个设备型号信息;
        /// </summary>
        [JsonProperty("aaid")]
        [XmlElement("aaid")]
        public string Aaid { get; set; }

        /// <summary>
        /// IFAA标准中的校验类型，目前1为指纹
        /// </summary>
        [JsonProperty("auth_type")]
        [XmlElement("auth_type")]
        public string AuthType { get; set; }

        /// <summary>
        /// buildModel，通过IFAA客户端SDK获取到的设备具体型号，android可通过设备厂商的公开API获取，iOS为设备的internalname，用于标示一台具体市场上的设备名称，
        /// </summary>
        [JsonProperty("build_model")]
        [XmlElement("build_model")]
        public string BuildModel { get; set; }

        /// <summary>
        /// 设备ID，android为IFAA TA里定义，iOS为IFAA定义后存储在keyChain，接入方调用指纹客户端SDK获取，无需自己取值，用于用户绑定，区分单设备用户
        /// </summary>
        [JsonProperty("device_id")]
        [XmlElement("device_id")]
        public string DeviceId { get; set; }
    }
}
