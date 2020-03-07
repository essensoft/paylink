using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankFinanceAccountRysenterpriseQueryResponse.
    /// </summary>
    public class MybankFinanceAccountRysenterpriseQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 融易收账户Id
        /// </summary>
        [JsonPropertyName("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 融易收账户可用余额
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }
    }
}
