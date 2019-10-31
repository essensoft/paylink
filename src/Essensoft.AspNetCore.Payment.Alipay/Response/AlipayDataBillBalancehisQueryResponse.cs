using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataBillBalancehisQueryResponse.
    /// </summary>
    public class AlipayDataBillBalancehisQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 期初余额
        /// </summary>
        [JsonProperty("beginning_balance")]
        public string BeginningBalance { get; set; }

        /// <summary>
        /// 期末余额
        /// </summary>
        [JsonProperty("ending_balance")]
        public string EndingBalance { get; set; }
    }
}
