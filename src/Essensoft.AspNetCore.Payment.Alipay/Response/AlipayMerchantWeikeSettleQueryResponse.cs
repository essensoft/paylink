using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMerchantWeikeSettleQueryResponse.
    /// </summary>
    public class AlipayMerchantWeikeSettleQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 分页查询页号，从1开始
        /// </summary>
        [JsonPropertyName("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页查询页大小，最大100
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 用户任务列表
        /// </summary>
        [JsonPropertyName("user_task_views")]
        public List<UserTaskView> UserTaskViews { get; set; }
    }
}
