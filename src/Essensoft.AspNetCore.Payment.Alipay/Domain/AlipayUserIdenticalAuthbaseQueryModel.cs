using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserIdenticalAuthbaseQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserIdenticalAuthbaseQueryModel : AlipayObject
    {
        /// <summary>
        /// 需要校验的userId，该参数需要用作请求路由
        /// </summary>
        [JsonProperty("base_user_id")]
        public string BaseUserId { get; set; }

        /// <summary>
        /// 另一个需要校验的用户的支付宝账户ID
        /// </summary>
        [JsonProperty("comparator_user_id")]
        public string ComparatorUserId { get; set; }
    }
}
