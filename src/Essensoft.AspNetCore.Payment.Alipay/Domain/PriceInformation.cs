using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PriceInformation Data Structure.
    /// </summary>
    [Serializable]
    public class PriceInformation : AlipayObject
    {
        /// <summary>
        /// 对应资产的金额，比如88.66等。如果是现金，单位元
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 现金MONEY、家庭分FAMILY_POINT、会员分ANT_POINT等
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
