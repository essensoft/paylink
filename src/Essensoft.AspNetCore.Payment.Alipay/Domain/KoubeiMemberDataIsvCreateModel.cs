using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMemberDataIsvCreateModel Data Structure.
    /// </summary>
    public class KoubeiMemberDataIsvCreateModel : AlipayObject
    {
        /// <summary>
        /// 会员卡最近一次激活时间，格式：yyyy-MM-dd HH:MM:ss
        /// </summary>
        [JsonPropertyName("gmt_member_card_last_active")]
        public string GmtMemberCardLastActive { get; set; }

        /// <summary>
        /// 会员卡领取时间（开卡时间），格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("gmt_merber_card_create")]
        public string GmtMerberCardCreate { get; set; }

        /// <summary>
        /// 会员卡卡号：唯一标识会员卡的ID，partner_id+member_card_id是唯一主键，若partner_id+member_card_id已存在，则做更新会员卡操作。
        /// </summary>
        [JsonPropertyName("member_card_id")]
        public string MemberCardId { get; set; }

        /// <summary>
        /// 会员卡类型：  微卡、炫酷卡、儿童卡、璀璨卡、金卡银卡、白金卡等
        /// </summary>
        [JsonPropertyName("member_card_type")]
        public string MemberCardType { get; set; }

        /// <summary>
        /// 会员用户身份识别ID
        /// </summary>
        [JsonPropertyName("member_ship")]
        public MemberShip MemberShip { get; set; }

        /// <summary>
        /// 会员来源：  1：weixin（微信）；2：alipay（支付宝）；3：offline（线下会员卡）；4：other（其他）
        /// </summary>
        [JsonPropertyName("member_source")]
        public string MemberSource { get; set; }

        /// <summary>
        /// 会员来源描述：如美团、饿了么等
        /// </summary>
        [JsonPropertyName("member_source_desc")]
        public string MemberSourceDesc { get; set; }

        /// <summary>
        /// 会员状态：  1：生效；0：失效
        /// </summary>
        [JsonPropertyName("member_status")]
        public string MemberStatus { get; set; }

        /// <summary>
        /// 外部记录
        /// </summary>
        [JsonPropertyName("outer_member_info")]
        public OuterMemberInfo OuterMemberInfo { get; set; }

        /// <summary>
        /// 商户的PID
        /// </summary>
        [JsonPropertyName("parter_id")]
        public string ParterId { get; set; }

        /// <summary>
        /// 会员卡领取的门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
