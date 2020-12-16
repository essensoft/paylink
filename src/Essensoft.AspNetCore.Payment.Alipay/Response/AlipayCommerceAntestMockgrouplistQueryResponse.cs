using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceAntestMockgrouplistQueryResponse.
    /// </summary>
    public class AlipayCommerceAntestMockgrouplistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 挡板集列表
        /// </summary>
        [JsonPropertyName("data")]
        public List<EcoMockGroupInfo> Data { get; set; }
    }
}
