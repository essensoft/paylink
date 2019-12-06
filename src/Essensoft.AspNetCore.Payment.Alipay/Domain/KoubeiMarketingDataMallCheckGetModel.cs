using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingDataMallCheckGetModel Data Structure.
    /// </summary>
    public class KoubeiMarketingDataMallCheckGetModel : AlipayObject
    {
        /// <summary>
        /// 安全校验数据内容入参
        /// </summary>
        [JsonPropertyName("check_contents")]
        public List<DataSecCheckContent> CheckContents { get; set; }

        /// <summary>
        /// 数据源:USER--C端，MERCHANT--B端
        /// </summary>
        [JsonPropertyName("data_source")]
        public string DataSource { get; set; }
    }
}
