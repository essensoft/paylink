using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
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
