using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Alipay.Domain;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayEcapiprodDrawndnDrawndnlistQueryResponse.
    /// </summary>
    public class AlipayEcapiprodDrawndnDrawndnlistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支用列表
        /// </summary>
        [JsonProperty("drawndn_list")]
        public List<DrawndnVo> DrawndnList { get; set; }

        /// <summary>
        /// 唯一一次请求标示
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }
    }
}
