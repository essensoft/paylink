using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFundTransAuctionBalanceQueryResponse.
    /// </summary>
    public class AlipayFundTransAuctionBalanceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前可用余额
        /// </summary>
        [JsonPropertyName("balance_available")]
        public string BalanceAvailable { get; set; }

        /// <summary>
        /// 冻结金额
        /// </summary>
        [JsonPropertyName("balance_freezed")]
        public string BalanceFreezed { get; set; }
    }
}
