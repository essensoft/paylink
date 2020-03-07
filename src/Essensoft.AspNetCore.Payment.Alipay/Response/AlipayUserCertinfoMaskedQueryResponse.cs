using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserCertinfoMaskedQueryResponse.
    /// </summary>
    public class AlipayUserCertinfoMaskedQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 脱敏后的用户身份信息。【注意】如果入参中某一userId不存在，返回的视图列表中将不包含该userId对应视图。（举例：入参里10个userId，其中1个userId不存在，则出参列表里有9个视图）
        /// </summary>
        [JsonPropertyName("cert_views")]
        public List<MaskedUserCertView> CertViews { get; set; }
    }
}
