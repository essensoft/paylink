using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiItemBatchqueryResponse.
    /// </summary>
    public class KoubeiItemBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonProperty("current_page_no")]
        [XmlElement("current_page_no")]
        public string CurrentPageNo { get; set; }

        /// <summary>
        /// 商品信息
        /// </summary>
        [JsonProperty("item_infos")]
        [XmlArray("item_infos")]
        [XmlArrayItem("item_query_response")]
        public List<ItemQueryResponse> ItemInfos { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        [JsonProperty("page_size")]
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 总共商品数目
        /// </summary>
        [JsonProperty("total_items")]
        [XmlElement("total_items")]
        public string TotalItems { get; set; }

        /// <summary>
        /// 总页码数目
        /// </summary>
        [JsonProperty("total_page_no")]
        [XmlElement("total_page_no")]
        public string TotalPageNo { get; set; }
    }
}
