using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniPlanOperateBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniPlanOperateBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支付后推荐方案详情列表
        /// </summary>
        [JsonPropertyName("page_data")]
        public List<PaymentSuccessPagePlanInfo> PageData { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 支付后推荐方案记录总数
        /// </summary>
        [JsonPropertyName("total_number")]
        public long TotalNumber { get; set; }
    }
}
