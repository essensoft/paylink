using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CardCreditInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CardCreditInfo : AlipayObject
    {
        /// <summary>
        /// 是否允许超扣
        /// </summary>
        [JsonProperty("allowoverpay")]
        public string Allowoverpay { get; set; }

        /// <summary>
        /// 超扣额度
        /// </summary>
        [JsonProperty("creditquota")]
        public string Creditquota { get; set; }
    }
}
