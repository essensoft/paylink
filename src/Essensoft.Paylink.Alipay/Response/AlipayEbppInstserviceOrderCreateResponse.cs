using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInstserviceOrderCreateResponse.
    /// </summary>
    public class AlipayEbppInstserviceOrderCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 机构传入的流水号
        /// </summary>
        [JsonPropertyName("flow_id")]
        public string FlowId { get; set; }

        /// <summary>
        /// 落地结果
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
