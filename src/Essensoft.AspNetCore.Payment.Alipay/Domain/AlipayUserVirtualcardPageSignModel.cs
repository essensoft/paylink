using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserVirtualcardPageSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserVirtualcardPageSignModel : AlipayObject
    {
        /// <summary>
        /// 用户虚拟卡余额信息，单位为元，可精确到分。后付费卡不需要。
        /// </summary>
        [JsonProperty("balance")]
        public string Balance { get; set; }

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
        /// 卡的开通方式，分为直接开通DIRECT，二阶段开通TWO_PHASE
        /// </summary>
        [JsonProperty("card_sign_mode")]
        public string CardSignMode { get; set; }

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
        /// 卡不可用时引导用户的链接。无此需求则无需关注
        /// </summary>
        [JsonProperty("disabled_url")]
        public string DisabledUrl { get; set; }

        /// <summary>
        /// json格式字符串，存放扩展信息。整个值作为字符串，请注意转义问题。
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }
    }
}
