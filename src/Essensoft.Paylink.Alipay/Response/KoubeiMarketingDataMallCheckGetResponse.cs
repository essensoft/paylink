using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingDataMallCheckGetResponse.
    /// </summary>
    public class KoubeiMarketingDataMallCheckGetResponse : AlipayResponse
    {
        /// <summary>
        /// 返回数据字段
        /// </summary>
        [JsonPropertyName("data_results")]
        public List<DataSecCheckResult> DataResults { get; set; }
    }
}
