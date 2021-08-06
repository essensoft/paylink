using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInvoiceExpenserulesProjectruleQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceExpenserulesProjectruleQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前页数
        /// </summary>
        [JsonPropertyName("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 当前记录数
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 项目规则列表
        /// </summary>
        [JsonPropertyName("project_rule_info_list")]
        public List<ProjectRuleInfo> ProjectRuleInfoList { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [JsonPropertyName("total_count")]
        public string TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [JsonPropertyName("total_page_count")]
        public string TotalPageCount { get; set; }
    }
}
