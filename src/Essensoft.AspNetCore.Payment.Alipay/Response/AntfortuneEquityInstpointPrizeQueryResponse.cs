using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntfortuneEquityInstpointPrizeQueryResponse.
    /// </summary>
    public class AntfortuneEquityInstpointPrizeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 积分可兑换奖品列表
        /// </summary>
        [JsonPropertyName("prize_info")]
        public List<PointPrizeInfo> PrizeInfo { get; set; }

        /// <summary>
        /// 可兑换奖品总数
        /// </summary>
        [JsonPropertyName("total_count")]
        public string TotalCount { get; set; }
    }
}
