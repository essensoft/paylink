using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserAntpaasTestaccountCreateResponse.
    /// </summary>
    public class AlipayUserAntpaasTestaccountCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 认证等级，L1 L2 L3
        /// </summary>
        [JsonPropertyName("account_level")]
        public string AccountLevel { get; set; }

        /// <summary>
        /// 证件中的姓名，必须为中文，尽量不要超过6个汉字
        /// </summary>
        [JsonPropertyName("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，IDENTITY_CARD 身份证，PASSPORT 护照，HK_MC_CARD 港澳证件
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// havanaId
        /// </summary>
        [JsonPropertyName("havana_id")]
        public string HavanaId { get; set; }

        /// <summary>
        /// abc123@alitest.com
        /// </summary>
        [JsonPropertyName("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 登录名类型，EMAIL,MOBILE
        /// </summary>
        [JsonPropertyName("logon_type")]
        public string LogonType { get; set; }

        /// <summary>
        /// message，错误信息
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// 支付密码
        /// </summary>
        [JsonPropertyName("payment_password")]
        public string PaymentPassword { get; set; }

        /// <summary>
        /// 登录密码
        /// </summary>
        [JsonPropertyName("query_password")]
        public string QueryPassword { get; set; }

        /// <summary>
        /// success，返回结果,T,F
        /// </summary>
        [JsonPropertyName("success")]
        public string Success { get; set; }

        /// <summary>
        /// 新创建的账户id，accountNo
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 账户状态，T,Q
        /// </summary>
        [JsonPropertyName("user_status")]
        public string UserStatus { get; set; }

        /// <summary>
        /// 账户类型，个人企业 PERSON ORG
        /// </summary>
        [JsonPropertyName("user_type")]
        public string UserType { get; set; }
    }
}
