using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayBossProdElecsealOrderApplyResponse.
    /// </summary>
    public class AlipayBossProdElecsealOrderApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 法务中台电子用印流水号
        /// </summary>
        [JsonPropertyName("seal_request_id")]
        public string SealRequestId { get; set; }
    }
}
