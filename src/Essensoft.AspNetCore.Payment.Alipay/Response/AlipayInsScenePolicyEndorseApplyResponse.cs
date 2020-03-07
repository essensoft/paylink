using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsScenePolicyEndorseApplyResponse.
    /// </summary>
    public class AlipayInsScenePolicyEndorseApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 批单号
        /// </summary>
        [JsonPropertyName("endorse_no")]
        public string EndorseNo { get; set; }

        /// <summary>
        /// 商户生成的批单请求单号【幂等字段】
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
