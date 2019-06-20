using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MiniAppClientVersionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MiniAppClientVersionInfo : AlipayObject
    {
        /// <summary>
        /// 最大客户端版本号信息
        /// </summary>
        [JsonProperty("max_client_version")]
        public string MaxClientVersion { get; set; }

        /// <summary>
        /// 最小客户端版本号
        /// </summary>
        [JsonProperty("min_client_version")]
        public string MinClientVersion { get; set; }
    }
}
