using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayUserInviteOnlinesummaryQueryResponse.
    /// </summary>
    public class AlipayUserInviteOnlinesummaryQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 线上拉新结算汇总数据列表
        /// </summary>
        [JsonPropertyName("online_summary_info_list")]
        public List<OnlineInviteNewerSummaryInfo> OnlineSummaryInfoList { get; set; }
    }
}
