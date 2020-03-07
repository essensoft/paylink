using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataZbdmLineageQueryResponse.
    /// </summary>
    public class AlipayDataZbdmLineageQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 参数名：返回血缘探索的边集合 应用场景：返回边的起始id，终止id已经反向 如何获取：geabase中获取
        /// </summary>
        [JsonPropertyName("edges")]
        public List<string> Edges { get; set; }

        /// <summary>
        /// 参数名:返回血缘探索的点集合 应用场景:返回一张表/字段上下游20层以内的表/字段 如何获取：从geabase中获取
        /// </summary>
        [JsonPropertyName("vertices")]
        public List<string> Vertices { get; set; }
    }
}
