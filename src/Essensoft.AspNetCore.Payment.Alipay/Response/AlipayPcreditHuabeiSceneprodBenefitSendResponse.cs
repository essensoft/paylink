using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiSceneprodBenefitSendResponse.
    /// </summary>
    public class AlipayPcreditHuabeiSceneprodBenefitSendResponse : AlipayResponse
    {
        /// <summary>
        /// 是否需要重试
        /// </summary>
        [JsonPropertyName("retry")]
        public string Retry { get; set; }

        /// <summary>
        /// 发放单ID
        /// </summary>
        [JsonPropertyName("send_id")]
        public string SendId { get; set; }

        /// <summary>
        /// 发放单状态，I:表示发放中、N:表示发放失败(属于重试也无法成功,比如预算不足等)、Y:表示发放成功
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
