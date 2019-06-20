using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserVirtualcardSignEffectModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserVirtualcardSignEffectModel : AlipayObject
    {
        /// <summary>
        /// hex格式表示的虚拟卡数据，卡数据将在虚拟卡二维码中透传。
        /// </summary>
        [JsonProperty("card_data")]
        public string CardData { get; set; }

        /// <summary>
        /// 商户定义的卡号，card_type+card_no要控制唯一性
        /// </summary>
        [JsonProperty("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 卡类型，由支付宝指定。目前每个商户都有自己的卡类型，一家商户还可能有多个卡类型
        /// </summary>
        [JsonProperty("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 表示虚拟卡是否可用
        /// </summary>
        [JsonProperty("disabled")]
        public string Disabled { get; set; }

        /// <summary>
        /// 当虚拟卡不可用时，提示用户不可用原因
        /// </summary>
        [JsonProperty("disabled_tips")]
        public string DisabledTips { get; set; }

        /// <summary>
        /// 卡不可用时引导用户的链接
        /// </summary>
        [JsonProperty("disabled_url")]
        public string DisabledUrl { get; set; }

        /// <summary>
        /// json格式字符串，存放扩展信息。
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
