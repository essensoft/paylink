using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTradeCustomsQueryResponse.
    /// </summary>
    public class AlipayTradeCustomsQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 不存在记录的报关请求号。多个值用逗号分隔，单次最多10个;每个报关请求号String(32)
        /// </summary>
        [JsonProperty("not_found")]
        public string NotFound { get; set; }

        /// <summary>
        /// 匹配到的列表。每个记录代表一条报关记录
        /// </summary>
        [JsonProperty("records")]
        public List<CustomsDeclareRecordInfo> Records { get; set; }
    }
}
