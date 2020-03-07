using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserInviteOnlinedetailQueryResponse.
    /// </summary>
    public class AlipayUserInviteOnlinedetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 线上拉新结算明细数据列表
        /// </summary>
        [JsonPropertyName("online_detail_info_list")]
        public List<OnlineInviteNewerDetailInfo> OnlineDetailInfoList { get; set; }

        /// <summary>
        /// 页大小
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
