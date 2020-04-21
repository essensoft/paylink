using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PlanOperateContent Data Structure.
    /// </summary>
    public class PlanOperateContent : AlipayObject
    {
        /// <summary>
        /// 内容入参 key, 支持的枚举值: APP_SKIP_URL:小程序跳转链接, MEMBER_CARD_OPEN_URL: 会员卡开通链接, BENEFIT_TEXT: 权益文案
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 内容入参值, 具体内容参照 key 的枚举值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
