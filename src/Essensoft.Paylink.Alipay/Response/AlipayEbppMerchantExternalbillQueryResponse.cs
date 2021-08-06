using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEbppMerchantExternalbillQueryResponse.
    /// </summary>
    public class AlipayEbppMerchantExternalbillQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 账单列表
        /// </summary>
        [JsonPropertyName("external_bill_list")]
        public List<ExternalBillInfoResult> ExternalBillList { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonPropertyName("page_number")]
        public long PageNumber { get; set; }

        /// <summary>
        /// 分页条数
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询总数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }
    }
}
