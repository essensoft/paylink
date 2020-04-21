using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceMindvAnswersBatchqueryResponse.
    /// </summary>
    public class AlipayIserviceMindvAnswersBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前分页码_和入参保持一致
        /// </summary>
        [JsonPropertyName("current_page_num")]
        public long CurrentPageNum { get; set; }

        /// <summary>
        /// 用户提交结果数据
        /// </summary>
        [JsonPropertyName("page_data")]
        public List<UserSubmitModel> PageData { get; set; }

        /// <summary>
        /// 每页数量限制_和入参保持一致
        /// </summary>
        [JsonPropertyName("per_page_size")]
        public long PerPageSize { get; set; }

        /// <summary>
        /// 总的数据数量_提供给业务方自行判断是否继续查询后续数据
        /// </summary>
        [JsonPropertyName("total_num")]
        public long TotalNum { get; set; }
    }
}
