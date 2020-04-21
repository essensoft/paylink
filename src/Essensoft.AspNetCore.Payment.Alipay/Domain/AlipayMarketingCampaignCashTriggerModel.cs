using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignCashTriggerModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignCashTriggerModel : AlipayObject
    {
        /// <summary>
        /// 现金活动号
        /// </summary>
        [JsonPropertyName("crowd_no")]
        public string CrowdNo { get; set; }

        /// <summary>
        /// 用户登录账号名：邮箱或手机号。user_id与login_id至少有一个非空，都非空时，以user_id为准。
        /// </summary>
        [JsonPropertyName("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 此字段如果传入金额，就忽略prize_type算法，按照传入的金额发奖。如果不传或者小于等于0，则按照活动创建时指定的prize_type为fixed或者random算法发奖
        /// </summary>
        [JsonPropertyName("order_price")]
        public string OrderPrice { get; set; }

        /// <summary>
        /// 领取红包的外部业务号，只由可由字母、数字、下划线组成。同一个活动中不可重复，相同的外部业务号会被幂等并返回之前的结果。不填时，系统会生成一个默认固定的外部业务号。
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 用户唯一标识userId。user_id与login_id至少有一个非空；都非空时，以user_id为准。
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
