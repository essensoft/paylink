using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayUserDtbankcustChannelvoucherconfigQueryResponse.
    /// </summary>
    public class AlipayUserDtbankcustChannelvoucherconfigQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 数字分行活动唯一id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 渠道红包活动名称描述
        /// </summary>
        [JsonPropertyName("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动状态 CREATED="已创建", PUBLISHING="发布中", PUBLISHED_FAILED="发布失败", GREY="已发布(白名单验证中)", GOING="已发布", PAUSED="已暂停", ENDED="已结束"
        /// </summary>
        [JsonPropertyName("activity_status")]
        public string ActivityStatus { get; set; }

        /// <summary>
        /// CREDIT:信用卡 DEBIT:借记卡 DEBIT_CREDIT:借记卡或信用卡
        /// </summary>
        [JsonPropertyName("bank_card_type")]
        public string BankCardType { get; set; }

        /// <summary>
        /// 红包发放时间配置模型
        /// </summary>
        [JsonPropertyName("benefit_send_time")]
        public BenefitSendTime BenefitSendTime { get; set; }

        /// <summary>
        /// 银行卡卡bin配置，列表类型,以逗号分隔的字符串数组
        /// </summary>
        [JsonPropertyName("card_bin_list")]
        public List<string> CardBinList { get; set; }

        /// <summary>
        /// 红包发放之后的生效时间配置
        /// </summary>
        [JsonPropertyName("coupon_effect_time")]
        public CouponEffectTime CouponEffectTime { get; set; }

        /// <summary>
        /// 活动发放和消耗信息  请注意：该结果可能存在2个小时之内的时间延迟，特殊情况下可能延迟会更久
        /// </summary>
        [JsonPropertyName("coupon_template_consume_info")]
        public CouponTemplateConsumeInfo CouponTemplateConsumeInfo { get; set; }

        /// <summary>
        /// 优惠立减信息配置
        /// </summary>
        [JsonPropertyName("discount_info_config")]
        public DiscountInfoConfig DiscountInfoConfig { get; set; }

        /// <summary>
        /// 最少发放红包份数，比如：88代表此活动最少能发88次红包。
        /// </summary>
        [JsonPropertyName("min_send_count")]
        public long MinSendCount { get; set; }

        /// <summary>
        /// 活动总预算值，以分为单位。如果值为999，则说明是9.99元预算
        /// </summary>
        [JsonPropertyName("total_budget")]
        public long TotalBudget { get; set; }

        /// <summary>
        /// 红包使用说明文案
        /// </summary>
        [JsonPropertyName("user_instruction_list")]
        public List<string> UserInstructionList { get; set; }
    }
}
