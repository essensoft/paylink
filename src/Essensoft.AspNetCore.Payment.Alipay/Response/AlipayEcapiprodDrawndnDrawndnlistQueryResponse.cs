using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcapiprodDrawndnDrawndnlistQueryResponse.
    /// </summary>
    public class AlipayEcapiprodDrawndnDrawndnlistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支用列表
        /// </summary>
        [JsonPropertyName("drawndn_list")]
        public List<DrawndnVo> DrawndnList { get; set; }

        /// <summary>
        /// 唯一一次请求标示
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
