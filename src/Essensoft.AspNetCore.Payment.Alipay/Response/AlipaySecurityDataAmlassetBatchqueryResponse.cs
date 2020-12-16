using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityDataAmlassetBatchqueryResponse.
    /// </summary>
    public class AlipaySecurityDataAmlassetBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 风险资产记录结果列表
        /// </summary>
        [JsonPropertyName("asset_records")]
        public List<AmlAssetRecord> AssetRecords { get; set; }
    }
}
