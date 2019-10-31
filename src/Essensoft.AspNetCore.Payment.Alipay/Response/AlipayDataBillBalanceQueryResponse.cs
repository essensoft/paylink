using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataBillBalanceQueryResponse.
    /// </summary>
    public class AlipayDataBillBalanceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 账户可用余额
        /// </summary>
        [JsonProperty("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 冻结金额
        /// </summary>
        [JsonProperty("freeze_amount")]
        public string FreezeAmount { get; set; }

        /// <summary>
        /// 支付宝账户余额
        /// </summary>
        [JsonProperty("total_amount")]
        public string TotalAmount { get; set; }
    }
}
