using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MultiCurrencyMoneyVO Data Structure.
    /// </summary>
    [Serializable]
    public class MultiCurrencyMoneyVO : AlipayObject
    {
        /// <summary>
        /// 金额，默认单位是人民币，精确到小数点两位，单位元
        /// </summary>
        [JsonProperty("amt")]
        public string Amt { get; set; }

        /// <summary>
        /// 币种，枚举值：1.CNY（人民币）2.USD（美元）3.HKD（港元）4.TWD（台币）5.EUR（欧元）6.GBP（英镑）7.JPY（日元）
        /// </summary>
        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }
    }
}
