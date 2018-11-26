using System.Collections.Generic;
using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingVoucherTemplatelistQueryResponse.
    /// </summary>
    public class AlipayMarketingVoucherTemplatelistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前页码,页码从1开始
        /// </summary>
        [JsonProperty("current_page")]
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [JsonProperty("items_per_page")]
        [XmlElement("items_per_page")]
        public long ItemsPerPage { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [JsonProperty("total_items")]
        [XmlElement("total_items")]
        public long TotalItems { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [JsonProperty("total_pages")]
        [XmlElement("total_pages")]
        public long TotalPages { get; set; }

        /// <summary>
        /// 券模板列表
        /// </summary>
        [JsonProperty("voucher_templates")]
        [XmlArray("voucher_templates")]
        [XmlArrayItem("voucher_template_lite_info")]
        public List<VoucherTemplateLiteInfo> VoucherTemplates { get; set; }
    }
}
