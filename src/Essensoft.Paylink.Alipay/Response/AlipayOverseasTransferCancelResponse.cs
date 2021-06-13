using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasTransferCancelResponse.
    /// </summary>
    public class AlipayOverseasTransferCancelResponse : AlipayResponse
    {
        /// <summary>
        /// 透传信息
        /// </summary>
        [JsonPropertyName("pass_through_info")]
        public string PassThroughInfo { get; set; }
    }
}
