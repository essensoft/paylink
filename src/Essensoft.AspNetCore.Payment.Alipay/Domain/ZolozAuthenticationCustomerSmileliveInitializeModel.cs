using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZolozAuthenticationCustomerSmileliveInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZolozAuthenticationCustomerSmileliveInitializeModel : AlipayObject
    {
        /// <summary>
        /// { "apdidToken": "设备指纹", "appName": "应用名称", "appVersion": "应用版本", "bioMetaInfo": "生物信息如2.3.0:3,-4" }
        /// </summary>
        [JsonProperty("zimmetainfo")]
        public string Zimmetainfo { get; set; }
    }
}
