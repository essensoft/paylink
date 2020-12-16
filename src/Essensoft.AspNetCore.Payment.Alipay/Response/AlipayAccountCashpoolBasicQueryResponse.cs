using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayAccountCashpoolBasicQueryResponse.
    /// </summary>
    public class AlipayAccountCashpoolBasicQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 资金池总数量
        /// </summary>
        [JsonPropertyName("count")]
        public long Count { get; set; }

        /// <summary>
        /// 资金池基本信息查询结果
        /// </summary>
        [JsonPropertyName("inst_basic_cash_pool_list")]
        public List<string> InstBasicCashPoolList { get; set; }
    }
}
