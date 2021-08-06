using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasTransferCertifyResponse.
    /// </summary>
    public class AlipayOverseasTransferCertifyResponse : AlipayResponse
    {
        /// <summary>
        /// 是否有默认卡
        /// </summary>
        [JsonPropertyName("has_default_card")]
        public string HasDefaultCard { get; set; }

        /// <summary>
        /// 透传信息
        /// </summary>
        [JsonPropertyName("pass_through_info")]
        public string PassThroughInfo { get; set; }
    }
}
