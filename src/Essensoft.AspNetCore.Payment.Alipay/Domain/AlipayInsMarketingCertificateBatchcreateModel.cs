using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

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
        [XmlArray("ins_create_certificate_requests")]
        [XmlArrayItem("ins_create_certificate_request")]
        public List<InsCreateCertificateRequest> InsCreateCertificateRequests { get; set; }
    }
}
