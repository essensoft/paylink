using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ExtraInfoVO Data Structure.
    /// </summary>
    public class ExtraInfoVO : AlipayObject
    {
        /// <summary>
        /// 是否是taomaomao好友关系
        /// </summary>
        [JsonPropertyName("maomao_friend")]
        public bool MaomaoFriend { get; set; }

        /// <summary>
        /// 是否注册taomaomao游戏
        /// </summary>
        [JsonPropertyName("maomao_register")]
        public bool MaomaoRegister { get; set; }

        /// <summary>
        /// 支付宝对应的taobao_id
        /// </summary>
        [JsonPropertyName("taobao_id")]
        public string TaobaoId { get; set; }
    }
}
