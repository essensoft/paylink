using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CreditFinancePayAccountInfo Data Structure.
    /// </summary>
    public class CreditFinancePayAccountInfo : AlipayObject
    {
        /// <summary>
        /// 账号的扩展信息，String格式的json字符串
        /// </summary>
        [JsonPropertyName("account_ext")]
        public string AccountExt { get; set; }

        /// <summary>
        /// 支付的账号标识
        /// </summary>
        [JsonPropertyName("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 支付宝唯一标识的类型 ENTRUST_ACCOUNT USER_ID
        /// </summary>
        [JsonPropertyName("identity_type")]
        public string IdentityType { get; set; }
    }
}
