using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialBaseChatGroupsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseChatGroupsQueryModel : AlipayObject
    {
        /// <summary>
        /// 上次接口返回的key，初始传0
        /// </summary>
        [JsonProperty("last_key")]
        public long LastKey { get; set; }
    }
}
