using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
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
