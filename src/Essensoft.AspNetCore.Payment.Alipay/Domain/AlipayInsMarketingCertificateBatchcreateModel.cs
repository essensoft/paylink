using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsMarketingCertificateBatchcreateModel Data Structure.
    /// </summary>
    public class AlipayInsMarketingCertificateBatchcreateModel : AlipayObject
    {
        /// <summary>
        /// 批量创建凭证请求
        /// </summary>
        [JsonPropertyName("ins_create_certificate_requests")]
        public List<InsCreateCertificateRequest> InsCreateCertificateRequests { get; set; }
    }
}
