using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayBossFncUserinvoiceinfoOuQueryResponse.
    /// </summary>
    public class AlipayBossFncUserinvoiceinfoOuQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 开票资料
        /// </summary>
        [JsonPropertyName("result_set")]
        public ApUserInvoiceInfoOpenApiResponse ResultSet { get; set; }
    }
}
