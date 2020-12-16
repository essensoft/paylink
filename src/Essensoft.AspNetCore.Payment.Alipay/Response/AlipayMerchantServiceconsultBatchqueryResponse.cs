using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMerchantServiceconsultBatchqueryResponse.
    /// </summary>
    public class AlipayMerchantServiceconsultBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 服务咨询工单列表信息
        /// </summary>
        [JsonPropertyName("consult_infos")]
        public List<ServiceConsultQueryResponse> ConsultInfos { get; set; }

        /// <summary>
        /// 当前页码数
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [JsonPropertyName("total_num")]
        public long TotalNum { get; set; }

        /// <summary>
        /// 总页码数
        /// </summary>
        [JsonPropertyName("total_page_num")]
        public long TotalPageNum { get; set; }
    }
}
