using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsSceneCouponSendResponse.
    /// </summary>
    public class AlipayInsSceneCouponSendResponse : AlipayResponse
    {
        /// <summary>
        /// 发奖凭证
        /// </summary>
        [JsonPropertyName("certificate")]
        public InsCertificate Certificate { get; set; }

        /// <summary>
        /// 活动ID
        /// </summary>
        [JsonPropertyName("compaign_id")]
        public string CompaignId { get; set; }

        /// <summary>
        /// 发奖流水ID
        /// </summary>
        [JsonPropertyName("flow_id")]
        public string FlowId { get; set; }

        /// <summary>
        /// 保险产品
        /// </summary>
        [JsonPropertyName("product")]
        public InsProduct Product { get; set; }
    }
}
