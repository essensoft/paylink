using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobilePublicLabelUserDeleteResponse.
    /// </summary>
    public class AlipayMobilePublicLabelUserDeleteResponse : AlipayResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [JsonPropertyName("code")]
        public override string Code { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [JsonPropertyName("msg")]
        public override string Msg { get; set; }
    }
}
