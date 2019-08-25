using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CreditPayMoneyVO Data Structure.
    /// </summary>
    [Serializable]
    public class CreditPayMoneyVO : AlipayObject
    {
        /// <summary>
        /// 金额，单位元
        /// </summary>
        [JsonProperty("amt")]
        public string Amt { get; set; }

        /// <summary>
        /// 币种代码
        /// </summary>
        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }
    }
}
