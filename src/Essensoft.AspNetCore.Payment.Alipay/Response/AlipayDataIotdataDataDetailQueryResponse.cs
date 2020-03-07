using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataIotdataDataDetailQueryResponse.
    /// </summary>
    public class AlipayDataIotdataDataDetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 感知数据列表
        /// </summary>
        [JsonPropertyName("data")]
        public List<SummaryData> Data { get; set; }
    }
}
