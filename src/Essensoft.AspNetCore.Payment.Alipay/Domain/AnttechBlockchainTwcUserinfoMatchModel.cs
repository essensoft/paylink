using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AnttechBlockchainTwcUserinfoMatchModel Data Structure.
    /// </summary>
    public class AnttechBlockchainTwcUserinfoMatchModel : AlipayObject
    {
        /// <summary>
        /// 支付宝的UID
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 移动号码hash后的字符串
        /// </summary>
        [JsonPropertyName("call_no_hash")]
        public string CallNoHash { get; set; }

        /// <summary>
        /// 注册使用的用户名
        /// </summary>
        [JsonPropertyName("unify_no")]
        public string UnifyNo { get; set; }

        /// <summary>
        /// 名字证件号对应的sha256的hash值
        /// </summary>
        [JsonPropertyName("unify_no_hash")]
        public string UnifyNoHash { get; set; }
    }
}
