using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignCashTriggerModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignCashTriggerModel : AlipayObject
    {
        /// <summary>
        /// 现金活动号
        /// </summary>
        [JsonProperty("crowd_no")]
        public string CrowdNo { get; set; }

        /// <summary>
        /// 用户登录账号名：邮箱或手机号。user_id与login_id至少有一个非空，都非空时，以user_id为准。
        /// </summary>
        [JsonProperty("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 发奖金额
        /// </summary>
        [JsonProperty("order_price")]
        public string OrderPrice { get; set; }

        /// <summary>
        /// 领取红包的外部业务号，只由可由字母、数字、下划线组成。同一个活动中不可重复，相同的外部业务号会被幂等并返回之前的结果。不填时，系统会生成一个默认固定的外部业务号。
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 用户唯一标识userId。user_id与login_id至少有一个非空；都非空时，以user_id为准。
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
