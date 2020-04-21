using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicAccountCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicAccountCreateModel : AlipayObject
    {
        /// <summary>
        /// 账户添加成功，在支付宝与其对应的协议号。如果账户重复添加，接口保证幂等依然视为添加成功，返回此前该账户在支付宝对应的协议号。其他异常该字段不存在。
        /// </summary>
        [JsonPropertyName("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 绑定帐号，建议在开发者的系统中保持唯一性
        /// </summary>
        [JsonPropertyName("bind_account_no")]
        public string BindAccountNo { get; set; }

        /// <summary>
        /// 开发者期望在服务窗首页看到的关于该用户的显示信息，最长10个字符
        /// </summary>
        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// 要绑定的商户会员对应的支付宝userid，2088开头长度为16位的字符串
        /// </summary>
        [JsonPropertyName("from_user_id")]
        public string FromUserId { get; set; }

        /// <summary>
        /// 要绑定的商户会员的真实姓名，最长10个汉字
        /// </summary>
        [JsonPropertyName("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 备注信息，开发者可以通过该字段纪录其他的额外信息
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }
    }
}
