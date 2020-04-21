using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportWorldVirtualcardApplyModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportWorldVirtualcardApplyModel : AlipayObject
    {
        /// <summary>
        /// 虚拟卡行为，暂时只有海外用户领卡WORLD_ISSUE
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// 用户的卡数据，领卡时可不填
        /// </summary>
        [JsonPropertyName("card_data")]
        public string CardData { get; set; }

        /// <summary>
        /// 用户的卡号，销号和卡更新时必填，领卡时不填。
        /// </summary>
        [JsonPropertyName("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 卡类型，城市交通部门维度，如羊城通是一种cardtype，上海公交也是一种cardtype。
        /// </summary>
        [JsonPropertyName("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// json格式字符串，存放扩展信息。agreement_id--代扣协议号。本期的大湾区必填。
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 领卡的目标商户ID，比如羊城通的PID。
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 请求来源，本期大湾区只支持GN_HK。
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
