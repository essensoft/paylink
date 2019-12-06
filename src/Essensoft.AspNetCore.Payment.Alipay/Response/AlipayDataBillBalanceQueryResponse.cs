using System.Text.Json.Serialization;

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
        [JsonPropertyName("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 冻结金额
        /// </summary>
        [JsonPropertyName("freeze_amount")]
        public string FreezeAmount { get; set; }

        /// <summary>
        /// 支付宝账户余额
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }
    }
}
