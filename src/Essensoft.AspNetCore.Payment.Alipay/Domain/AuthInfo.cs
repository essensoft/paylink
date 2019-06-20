using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AuthInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AuthInfo : AlipayObject
    {
        /// <summary>
        /// 授权号
        /// </summary>
        [JsonProperty("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 授权类型
        /// </summary>
        [JsonProperty("auth_type")]
        public string AuthType { get; set; }
    }
}
