using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceEducateTuitioncodeOrdersQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateTuitioncodeOrdersQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 订单列表
        /// </summary>
        [JsonPropertyName("data")]
        public List<RechargeOrderTuitionDTO> Data { get; set; }

        /// <summary>
        /// 当前分页数
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 记录总数
        /// </summary>
        [JsonPropertyName("total_size")]
        public long TotalSize { get; set; }
    }
}
