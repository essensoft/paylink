using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingDataMallCheckGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataMallCheckGetModel : AlipayObject
    {
        /// <summary>
        /// 安全校验数据内容入参
        /// </summary>
        [JsonProperty("check_contents")]
        public List<DataSecCheckContent> CheckContents { get; set; }

        /// <summary>
        /// 数据源:USER--C端，MERCHANT--B端
        /// </summary>
        [JsonProperty("data_source")]
        public string DataSource { get; set; }
    }
}
