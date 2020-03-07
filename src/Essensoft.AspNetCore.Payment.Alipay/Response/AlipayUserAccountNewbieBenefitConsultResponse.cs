using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserAccountNewbieBenefitConsultResponse.
    /// </summary>
    public class AlipayUserAccountNewbieBenefitConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 脱敏后的支付宝登录号
        /// </summary>
        [JsonPropertyName("alipay_logon_id")]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// 权益信息
        /// </summary>
        [JsonPropertyName("benefit_info")]
        public AntMemberBenefitInfo BenefitInfo { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [JsonPropertyName("result_desc")]
        public string ResultDesc { get; set; }

        /// <summary>
        /// 本次请求是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
