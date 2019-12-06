using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobilePublicShortlinkCreateResponse.
    /// </summary>
    public class AlipayMobilePublicShortlinkCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [JsonPropertyName("code")]
        public override string Code { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [JsonPropertyName("msg")]
        public override string Msg { get; set; }

        /// <summary>
        /// 短链接url
        /// </summary>
        [JsonPropertyName("shortlink")]
        public string Shortlink { get; set; }
    }
}
