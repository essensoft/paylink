using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserVirtualcardSignEffectResponse.
    /// </summary>
    public class AlipayUserVirtualcardSignEffectResponse : AlipayResponse
    {
        /// <summary>
        /// 商户定义的卡号，card_type+card_no要控制唯一性
        /// </summary>
        [JsonPropertyName("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 卡类型，由支付宝指定。目前每个商户都有自己的卡类型，一家商户还可能有多个卡类型
        /// </summary>
        [JsonPropertyName("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 用户签约的支付宝账号对应的支付宝唯一用户号。  以2088开头的16位纯数字组成。
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
