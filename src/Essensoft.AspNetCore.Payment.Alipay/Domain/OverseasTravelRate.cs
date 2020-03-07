using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OverseasTravelRate Data Structure.
    /// </summary>
    public class OverseasTravelRate : AlipayObject
    {
        /// <summary>
        /// 货币代码，ISO标准alpha- 3币种代码
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 货币icon的url地址
        /// </summary>
        [JsonPropertyName("currency_icon")]
        public string CurrencyIcon { get; set; }

        /// <summary>
        /// 汇率，double类型，为支付宝当面付的当前币种/CNY的汇率值，如1美元=6.2345人民币元，即汇率为6.2345
        /// </summary>
        [JsonPropertyName("rate")]
        public string Rate { get; set; }
    }
}
