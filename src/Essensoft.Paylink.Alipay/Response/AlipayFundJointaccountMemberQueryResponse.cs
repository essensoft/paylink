using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayFundJointaccountMemberQueryResponse.
    /// </summary>
    public class AlipayFundJointaccountMemberQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 共同账户ID
        /// </summary>
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 成员列表
        /// </summary>
        [JsonPropertyName("member_list")]
        public List<JointAccountMemberRespDTO> MemberList { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonPropertyName("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 页面记录数
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [JsonPropertyName("total_page_count")]
        public string TotalPageCount { get; set; }
    }
}
