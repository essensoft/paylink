using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayInsAutoBenefitUseResponse.
    /// </summary>
    public class AlipayInsAutoBenefitUseResponse : AlipayResponse
    {
        /// <summary>
        /// 蚂蚁平台使用记录id
        /// </summary>
        [JsonPropertyName("use_flow_id")]
        public string UseFlowId { get; set; }
    }
}
