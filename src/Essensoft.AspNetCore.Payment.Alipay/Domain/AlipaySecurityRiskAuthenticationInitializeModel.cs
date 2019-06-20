using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityRiskAuthenticationInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskAuthenticationInitializeModel : AlipayObject
    {
        /// <summary>
        /// 用于身份安全业务初始化的公共入参
        /// </summary>
        [JsonProperty("authentication_info")]
        public AuthenticationInfo AuthenticationInfo { get; set; }

        /// <summary>
        /// 用于身份安全业务初始化的业务入参
        /// </summary>
        [JsonProperty("biz_info")]
        public string BizInfo { get; set; }

        /// <summary>
        /// 环境信息，包含设备信息、APP版本等
        /// </summary>
        [JsonProperty("env_info")]
        public string EnvInfo { get; set; }
    }
}
