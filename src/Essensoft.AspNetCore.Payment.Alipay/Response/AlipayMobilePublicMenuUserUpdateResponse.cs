using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobilePublicMenuUserUpdateResponse.
    /// </summary>
    public class AlipayMobilePublicMenuUserUpdateResponse : AlipayResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [JsonPropertyName("code")]
        public override string Code { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [JsonPropertyName("msg")]
        public override string Msg { get; set; }
    }
}
