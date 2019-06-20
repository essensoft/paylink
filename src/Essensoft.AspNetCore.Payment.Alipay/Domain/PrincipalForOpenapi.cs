using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PrincipalForOpenapi Data Structure.
    /// </summary>
    [Serializable]
    public class PrincipalForOpenapi : AlipayObject
    {
        /// <summary>
        /// 用户id
        /// </summary>
        [JsonProperty("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        [JsonProperty("principal_type")]
        public string PrincipalType { get; set; }
    }
}
