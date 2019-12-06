using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobilePublicAccountResetResponse.
    /// </summary>
    public class AlipayMobilePublicAccountResetResponse : AlipayResponse
    {
        /// <summary>
        /// 这是新账户绑定成功后产生的协议号
        /// </summary>
        [JsonPropertyName("agreement_id")]
        public string AgreementId { get; set; }

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
