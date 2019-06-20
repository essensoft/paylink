using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsMarketingCertificateBatchcreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsMarketingCertificateBatchcreateModel : AlipayObject
    {
        /// <summary>
        /// 批量创建凭证请求
        /// </summary>
        [JsonProperty("ins_create_certificate_requests")]
        public List<InsCreateCertificateRequest> InsCreateCertificateRequests { get; set; }
    }
}
