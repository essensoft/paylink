using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobilePublicAccountAddResponse.
    /// </summary>
    public class AlipayMobilePublicAccountAddResponse : AlipayResponse
    {
        /// <summary>
        /// 账户添加成功，在支付宝与其对应的协议号。如果账户重复添加，接口保证幂等依然视为添加成功，返回此前该账户在支付宝对应的协议号。其他异常该字段不存在。
        /// </summary>
        [JsonPropertyName("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 成功
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
