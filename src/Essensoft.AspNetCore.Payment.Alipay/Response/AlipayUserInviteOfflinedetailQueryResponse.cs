using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserInviteOfflinedetailQueryResponse.
    /// </summary>
    public class AlipayUserInviteOfflinedetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 线下拉新结算明细数据列表
        /// </summary>
        [JsonPropertyName("offline_detail_info_list")]
        public List<OfflineInviteNewerDetailInfo> OfflineDetailInfoList { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [JsonPropertyName("total_page")]
        public long TotalPage { get; set; }
    }
}
