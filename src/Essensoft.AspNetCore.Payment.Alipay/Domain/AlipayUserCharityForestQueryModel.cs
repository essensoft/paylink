using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserCharityForestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCharityForestQueryModel : AlipayObject
    {
        /// <summary>
        /// 用户的支付宝账户ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
