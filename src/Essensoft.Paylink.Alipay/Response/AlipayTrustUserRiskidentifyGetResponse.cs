using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
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
