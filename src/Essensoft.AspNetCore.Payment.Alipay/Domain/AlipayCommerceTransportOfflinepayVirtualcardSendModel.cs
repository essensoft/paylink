using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportOfflinepayVirtualcardSendModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportOfflinepayVirtualcardSendModel : AlipayObject
    {
        /// <summary>
        /// 虚拟卡信息同步动作
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// 用户虚拟卡余额，单位元。
        /// </summary>
        [JsonPropertyName("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// hex格式表示的虚拟卡数据，卡数据将在虚拟卡二维码中透传。
        /// </summary>
        [JsonPropertyName("card_data")]
        public string CardData { get; set; }

        /// <summary>
        /// 用户虚拟卡卡号
        /// </summary>
        [JsonPropertyName("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 虚拟卡卡类型
        /// </summary>
        [JsonPropertyName("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 表示虚拟卡是否可用
        /// </summary>
        [JsonPropertyName("disabled")]
        public string Disabled { get; set; }

        /// <summary>
        /// 卡状态不可用时，标示卡的具体不可用状态。  CARD_OVERDUE ---- 欠费，CARD_REVOKING ---- 退卡中
        /// </summary>
        [JsonPropertyName("disabled_code")]
        public string DisabledCode { get; set; }

        /// <summary>
        /// 当虚拟卡不可用时，提示用户不可用原因。
        /// </summary>
        [JsonPropertyName("disabled_tips")]
        public string DisabledTips { get; set; }

        /// <summary>
        /// json格式字符串，存放扩展信息。discount_type ---- 优惠标识
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 虚拟卡最后更新时间 使用标准java时间格式
        /// </summary>
        [JsonPropertyName("last_update_time")]
        public string LastUpdateTime { get; set; }

        /// <summary>
        /// 子动作类型。取值为：VERIFY：表示核销；EXPIRE：表示过期
        /// </summary>
        [JsonPropertyName("sub_action")]
        public string SubAction { get; set; }

        /// <summary>
        /// 交易场景，标示卡当前的支付模式，如为空，则默认PCREDIT。  PCREDIT ---- 先享后付  EXTRA_PREPAY ---- 域外储值卡
        /// </summary>
        [JsonPropertyName("trade_scene")]
        public string TradeScene { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
