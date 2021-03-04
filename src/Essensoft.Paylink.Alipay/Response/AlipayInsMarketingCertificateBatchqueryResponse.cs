using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayInsMarketingCertificateBatchqueryResponse.
    /// </summary>
    public class AlipayInsMarketingCertificateBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 分页查询结果
        /// </summary>
        [JsonPropertyName("ins_certificate_pagination_list")]
        public InsCertificatePaginationList InsCertificatePaginationList { get; set; }
    }
}
