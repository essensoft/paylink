using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobileShakeUserQueryResponse.
    /// </summary>
    public class AlipayMobileShakeUserQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 对应的业务信息
        /// </summary>
        [JsonPropertyName("bizdata")]
        public string Bizdata { get; set; }

        /// <summary>
        /// 支付宝用户登录账户，可能是email或者手机号码
        /// </summary>
        [JsonPropertyName("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 对应的核销数据
        /// </summary>
        [JsonPropertyName("pass_id")]
        public string PassId { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
