using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceLotteryTypelistQueryResponse.
    /// </summary>
    public class AlipayCommerceLotteryTypelistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 彩票系统支持的可用于赠送的彩种类型列表
        /// </summary>
        [JsonProperty("results")]
        public List<LotteryType> Results { get; set; }

        /// <summary>
        /// 彩票系统支持的可用于赠送的彩种个数
        /// </summary>
        [JsonProperty("total_result")]
        public long TotalResult { get; set; }
    }
}
