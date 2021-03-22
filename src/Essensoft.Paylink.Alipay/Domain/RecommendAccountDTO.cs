using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// RecommendAccountDTO Data Structure.
    /// </summary>
    public class RecommendAccountDTO : AlipayObject
    {
        /// <summary>
        /// 推荐商家支付宝登录账号，邮箱或手机号码，脱敏处理
        /// </summary>
        [JsonPropertyName("alipay_account")]
        public string AlipayAccount { get; set; }

        /// <summary>
        /// 推荐商家支付宝账号名称，脱敏处理
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
    }
}
