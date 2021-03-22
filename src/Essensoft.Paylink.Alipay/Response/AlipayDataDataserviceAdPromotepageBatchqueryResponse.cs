using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdPromotepageBatchqueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdPromotepageBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 自建推广页详情列表
        /// </summary>
        [JsonPropertyName("list")]
        public List<PromotePageDetail> List { get; set; }

        /// <summary>
        /// 分页参数之页数
        /// </summary>
        [JsonPropertyName("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页参数之每页大小
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 分页参数之总数据量
        /// </summary>
        [JsonPropertyName("total")]
        public long Total { get; set; }
    }
}
