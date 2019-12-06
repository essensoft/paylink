using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTrustUserRiskidentifyGetResponse.
    /// </summary>
    public class AlipayTrustUserRiskidentifyGetResponse : AlipayResponse
    {
        /// <summary>
        /// 行业关注名单识别结果
        /// </summary>
        [JsonPropertyName("ali_trust_risk_identify")]
        public AliTrustRiskIdentify AliTrustRiskIdentify { get; set; }
    }
}
