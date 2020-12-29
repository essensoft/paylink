using System.Text.Json.Serialization;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceEducateCreditbankCertificateQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateCreditbankCertificateQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 获得证书信息
        /// </summary>
        [JsonPropertyName("certificates")]
        public List<CreditBankCertificateExperience> Certificates { get; set; }
    }
}
