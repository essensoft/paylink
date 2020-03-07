using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayAccountExrateSourcerateQueryResponse.
    /// </summary>
    public class AlipayAccountExrateSourcerateQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 源汇率记录
        /// </summary>
        [JsonPropertyName("source_rate_list")]
        public List<ExSourceRateVO> SourceRateList { get; set; }
    }
}
