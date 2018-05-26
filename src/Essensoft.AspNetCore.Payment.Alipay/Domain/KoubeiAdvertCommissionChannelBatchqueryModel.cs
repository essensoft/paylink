using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiAdvertCommissionChannelBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiAdvertCommissionChannelBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("page_index")]
        [XmlElement("page_index")]
        public string PageIndex { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [JsonProperty("page_size")]
        [XmlElement("page_size")]
        public string PageSize { get; set; }
    }
}
