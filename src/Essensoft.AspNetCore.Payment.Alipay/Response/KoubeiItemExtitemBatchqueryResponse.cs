using System.Collections.Generic;
using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiItemExtitemBatchqueryResponse.
    /// </summary>
    public class KoubeiItemExtitemBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商品信息列表
        /// </summary>
        [JsonProperty("model_list")]
        [XmlArray("model_list")]
        [XmlArrayItem("ext_item")]
        public List<ExtItem> ModelList { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonProperty("page_num")]
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [JsonProperty("page_size")]
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [JsonProperty("total_size")]
        [XmlElement("total_size")]
        public string TotalSize { get; set; }
    }
}
