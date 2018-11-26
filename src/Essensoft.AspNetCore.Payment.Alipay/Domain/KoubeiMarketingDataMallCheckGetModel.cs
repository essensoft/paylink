using System;
using System.Collections.Generic;
using System.Xml.Serialization;
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
        [XmlArray("check_contents")]
        [XmlArrayItem("data_sec_check_content")]
        public List<DataSecCheckContent> CheckContents { get; set; }

        /// <summary>
        /// 数据源:USER--C端，MERCHANT--B端
        /// </summary>
        [JsonProperty("data_source")]
        [XmlElement("data_source")]
        public string DataSource { get; set; }
    }
}
