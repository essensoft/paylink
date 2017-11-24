using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayInsMarketingCertificateBatchcreateModel Data Structure.
    /// </summary>
    public class AlipayInsMarketingCertificateBatchcreateModel : AlipayObject
    {
        /// <summary>
        /// 批量创建凭证请求
        /// </summary>
        [JsonProperty("ins_create_certificate_requests")]
        public List<InsCreateCertificateRequest> InsCreateCertificateRequests { get; set; }
    }
}
