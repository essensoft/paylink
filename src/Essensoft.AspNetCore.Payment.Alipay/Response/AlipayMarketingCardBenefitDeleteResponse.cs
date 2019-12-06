using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCardBenefitDeleteResponse.
    /// </summary>
    public class AlipayMarketingCardBenefitDeleteResponse : AlipayResponse
    {
        /// <summary>
        /// 权益删除结果；true成功，false失败
        /// </summary>
        [JsonPropertyName("result")]
        public bool Result { get; set; }
    }
}
