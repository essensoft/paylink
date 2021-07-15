using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingRecruitPlanlistQueryResponse.
    /// </summary>
    public class AlipayMarketingRecruitPlanlistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 方案列表
        /// </summary>
        [JsonPropertyName("data")]
        public List<RecruitPlanLight> Data { get; set; }

        /// <summary>
        /// 第几页，默认1（从1开始计数）
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页记录条数，默认20
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonPropertyName("total")]
        public long Total { get; set; }
    }
}
