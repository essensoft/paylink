using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiRetailWmsSupplierQueryResponse.
    /// </summary>
    public class KoubeiRetailWmsSupplierQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 供应商信息
        /// </summary>
        [JsonPropertyName("suppliers")]
        public List<SupplierVO> Suppliers { get; set; }

        /// <summary>
        /// 记录总数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }
    }
}
