using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFinanceFundFundFixedprofitQueryResponse.
    /// </summary>
    public class AlipayFinanceFundFundFixedprofitQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 过去5年定投收益率
        /// </summary>
        [JsonPropertyName("last_five_year")]
        public string LastFiveYear { get; set; }

        /// <summary>
        /// 近一年定投收益率
        /// </summary>
        [JsonPropertyName("last_one_year")]
        public string LastOneYear { get; set; }

        /// <summary>
        /// 最近三年定投收益率
        /// </summary>
        [JsonPropertyName("last_three_year")]
        public string LastThreeYear { get; set; }

        /// <summary>
        /// 过去2年定投收益率
        /// </summary>
        [JsonPropertyName("last_two_year")]
        public string LastTwoYear { get; set; }

        /// <summary>
        /// 自从成立以来
        /// </summary>
        [JsonPropertyName("since_establish")]
        public string SinceEstablish { get; set; }
    }
}
