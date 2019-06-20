using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MultiCurrencyMoneyOpenApi Data Structure.
    /// </summary>
    [Serializable]
    public class MultiCurrencyMoneyOpenApi : AlipayObject
    {
        /// <summary>
        /// 分
        /// </summary>
        [JsonProperty("cent")]
        public long Cent { get; set; }

        /// <summary>
        /// 币种类型值
        /// </summary>
        [JsonProperty("currency_value")]
        public string CurrencyValue { get; set; }
    }
}
