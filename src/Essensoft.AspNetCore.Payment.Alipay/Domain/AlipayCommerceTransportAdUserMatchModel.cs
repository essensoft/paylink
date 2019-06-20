using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportAdUserMatchModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportAdUserMatchModel : AlipayObject
    {
        /// <summary>
        /// 第三方平台用户ID
        /// </summary>
        [JsonProperty("third_user_id")]
        public string ThirdUserId { get; set; }
    }
}
