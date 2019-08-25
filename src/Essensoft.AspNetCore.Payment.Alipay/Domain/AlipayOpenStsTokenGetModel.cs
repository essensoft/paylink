using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenStsTokenGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenStsTokenGetModel : AlipayObject
    {
        /// <summary>
        /// 当前安全令牌
        /// </summary>
        [JsonProperty("security_token")]
        public string SecurityToken { get; set; }

        /// <summary>
        /// 终端运行环境信息
        /// </summary>
        [JsonProperty("terminal")]
        public Terminal Terminal { get; set; }
    }
}
