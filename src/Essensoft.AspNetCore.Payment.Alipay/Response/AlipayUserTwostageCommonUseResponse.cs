using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserTwostageCommonUseResponse.
    /// </summary>
    public class AlipayUserTwostageCommonUseResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝用户userId信息，因为用户已经在客户端给商户的小程序授权了，并且商户要通过userId信息挂接优惠券信息，所以可以无需脱敏返回给商户。
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 从码值解析出来的用户身份信息
        /// </summary>
        [JsonPropertyName("user_identity_info")]
        public UserIdentityInfo UserIdentityInfo { get; set; }
    }
}
