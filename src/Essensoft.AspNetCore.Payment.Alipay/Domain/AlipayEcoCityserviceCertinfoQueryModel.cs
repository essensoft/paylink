using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoCityserviceCertinfoQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoCityserviceCertinfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 用户证件信息列表。
        /// </summary>
        [JsonPropertyName("cert_infos")]
        public List<CertInfoRequest> CertInfos { get; set; }
    }
}
