using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInvoiceApplystatusQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceApplystatusQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 每笔交易开票状态
        /// </summary>
        [JsonPropertyName("apply_status_brief_dtos")]
        public List<OrderApplyStatusBriefDTO> ApplyStatusBriefDtos { get; set; }
    }
}
