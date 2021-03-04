using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayDataIotdataBusinessPointQueryResponse.
    /// </summary>
    public class AlipayDataIotdataBusinessPointQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 业务点位信息列表
        /// </summary>
        [JsonPropertyName("data")]
        public List<BusinessPoint> Data { get; set; }
    }
}
