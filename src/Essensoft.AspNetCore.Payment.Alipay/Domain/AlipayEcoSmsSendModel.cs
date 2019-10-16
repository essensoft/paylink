using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoSmsSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoSmsSendModel : AlipayObject
    {
        /// <summary>
        /// 发送内容
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// 待收信人手机号
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}
