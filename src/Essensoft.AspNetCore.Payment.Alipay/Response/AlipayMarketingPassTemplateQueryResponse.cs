using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingPassTemplateQueryResponse.
    /// </summary>
    public class AlipayMarketingPassTemplateQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前查询的页码，页码从1开始
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 当前查询的每页条数
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 卡券模板总数
        /// </summary>
        [JsonPropertyName("total")]
        public long Total { get; set; }

        /// <summary>
        /// 按page_size分页的总页数
        /// </summary>
        [JsonPropertyName("total_page")]
        public long TotalPage { get; set; }

        /// <summary>
        /// 卡券模板列表
        /// </summary>
        [JsonPropertyName("tpl_list")]
        public List<PassTemplateDetail> TplList { get; set; }
    }
}
