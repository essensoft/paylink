using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserDigitalidentityHealthcardQueryResponse.
    /// </summary>
    public class AlipayUserDigitalidentityHealthcardQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 健康卡输出聚合信息
        /// </summary>
        [JsonPropertyName("health_card_info")]
        public HealthCardInfo HealthCardInfo { get; set; }
    }
}
