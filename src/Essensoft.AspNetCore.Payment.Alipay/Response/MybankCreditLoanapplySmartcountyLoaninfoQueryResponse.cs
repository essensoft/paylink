using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditLoanapplySmartcountyLoaninfoQueryResponse.
    /// </summary>
    public class MybankCreditLoanapplySmartcountyLoaninfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 前准入状态
        /// </summary>
        [JsonPropertyName("admited")]
        public bool Admited { get; set; }

        /// <summary>
        /// 用户所在的县域编码列表，如果一个用户在三个县域中都有，则返回三个县域编码集
        /// </summary>
        [JsonPropertyName("county_area")]
        public List<string> CountyArea { get; set; }

        /// <summary>
        /// 是否是网商贷的用户
        /// </summary>
        [JsonPropertyName("mybank_user")]
        public bool MybankUser { get; set; }

        /// <summary>
        /// 是否展示入口, 降级时候为 false
        /// </summary>
        [JsonPropertyName("show_entrance")]
        public bool ShowEntrance { get; set; }
    }
}
