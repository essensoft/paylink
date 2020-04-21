using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserNewbenefitCreateResponse.
    /// </summary>
    public class AlipayUserNewbenefitCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 权益的ID，可以根据此ID对权益进行操作
        /// </summary>
        [JsonPropertyName("benefit_id")]
        public string BenefitId { get; set; }
    }
}
