using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringDishCommruleQueryResponse.
    /// </summary>
    public class KoubeiCateringDishCommruleQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 返回的数据集合
        /// </summary>
        [JsonPropertyName("kbdish_comm_rule_info_list")]
        public KbdishCommRuleInfo KbdishCommRuleInfoList { get; set; }

        /// <summary>
        /// 表示当前页码
        /// </summary>
        [JsonPropertyName("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 表示每页条数
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 数据总条数
        /// </summary>
        [JsonPropertyName("total_count")]
        public string TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [JsonPropertyName("total_page")]
        public string TotalPage { get; set; }
    }
}
