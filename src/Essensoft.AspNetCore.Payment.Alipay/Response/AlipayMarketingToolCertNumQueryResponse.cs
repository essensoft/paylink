using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingToolCertNumQueryResponse.
    /// </summary>
    public class AlipayMarketingToolCertNumQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 凭证可用点数列表。
        /// </summary>
        [JsonPropertyName("cert_available_num")]
        public List<CertAvailableNumVO> CertAvailableNum { get; set; }
    }
}
