using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StdPublicBindAccount Data Structure.
    /// </summary>
    public class StdPublicBindAccount : AlipayObject
    {
        /// <summary>
        /// 协议号是商户会员在支付宝公众账号中的唯一标识。
        /// </summary>
        [JsonPropertyName("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 公众账号ID
        /// </summary>
        [JsonPropertyName("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// 绑定的商户会员号
        /// </summary>
        [JsonPropertyName("bind_account_no")]
        public string BindAccountNo { get; set; }

        /// <summary>
        /// 公众账号期望支付宝用户在公众账号首页看到的关于该用户的显示信息，最长10个汉字。
        /// </summary>
        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// 绑定的商户会员对应的支付宝用户号，以2088 开头的16位数字。
        /// </summary>
        [JsonPropertyName("from_user_id")]
        public string FromUserId { get; set; }

        /// <summary>
        /// 绑定的商户会员的真实姓名，最长10个汉字。
        /// </summary>
        [JsonPropertyName("real_name")]
        public string RealName { get; set; }
    }
}
