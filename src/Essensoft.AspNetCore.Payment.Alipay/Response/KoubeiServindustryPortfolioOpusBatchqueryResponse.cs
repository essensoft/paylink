using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiServindustryPortfolioOpusBatchqueryResponse.
    /// </summary>
    public class KoubeiServindustryPortfolioOpusBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 素材列表
        /// </summary>
        [JsonPropertyName("opuses")]
        public List<OpusInfo> Opuses { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonPropertyName("total_size")]
        public long TotalSize { get; set; }
    }
}
