using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMobilePublicMenuAddResponse.
    /// </summary>
    public class AlipayMobilePublicMenuAddResponse : AlipayResponse
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
    }
}
