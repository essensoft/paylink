using System.Collections.Generic;
using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCraftsmanDataWorkBatchqueryResponse.
    /// </summary>
    public class KoubeiCraftsmanDataWorkBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonProperty("current_page_no")]
        [XmlElement("current_page_no")]
        public long CurrentPageNo { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        [JsonProperty("page_size")]
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总页码数目
        /// </summary>
        [JsonProperty("total_page_no")]
        [XmlElement("total_page_no")]
        public long TotalPageNo { get; set; }

        /// <summary>
        /// 总共手艺人作品数目
        /// </summary>
        [JsonProperty("total_works")]
        [XmlElement("total_works")]
        public long TotalWorks { get; set; }

        /// <summary>
        /// 作品信息列表
        /// </summary>
        [JsonProperty("works")]
        [XmlArray("works")]
        [XmlArrayItem("craftsman_work_open_model")]
        public List<CraftsmanWorkOpenModel> Works { get; set; }
    }
}
