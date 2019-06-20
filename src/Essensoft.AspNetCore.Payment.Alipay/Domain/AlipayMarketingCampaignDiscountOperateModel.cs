using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignDiscountOperateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignDiscountOperateModel : AlipayObject
    {
        /// <summary>
        /// 幂等控制code,控制重复新增，修改时候可以不设置。
        /// </summary>
        [JsonProperty("camp_code")]
        public string CampCode { get; set; }

        /// <summary>
        /// 用于账户立减优惠,渠道立减优惠活动时,在收银台页面显示给会员看,最多512个字符，汉字、英文字母、数字都算一个，本输入框支持简单的html符号。
        /// </summary>
        [JsonProperty("camp_desc")]
        public string CampDesc { get; set; }

        /// <summary>
        /// 当operate_type=CAMP_MODIFIED 必设置camp_id
        /// </summary>
        [JsonProperty("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 活动名称 不超过24个字符
        /// </summary>
        [JsonProperty("camp_name")]
        public string CampName { get; set; }

        /// <summary>
        /// 目前未开放该字段的定义,统一由支付宝后台配置，目前定义如下：  DISCOUNT("discount", "支付宝立减")  REDUCE("reduce", "支付宝立减")  SINGLE("single", "支付宝立减")  RANDOM_DISCOUNT("random", "支付宝随机立减")
        /// </summary>
        [JsonProperty("camp_slogan")]
        public string CampSlogan { get; set; }

        /// <summary>
        /// 折扣方式模型 如果类型选了discount,则这个模型必须输入
        /// </summary>
        [JsonProperty("discount_dst_camp_prize_model")]
        public DiscountDstCampPrizeModel DiscountDstCampPrizeModel { get; set; }

        /// <summary>
        /// 立减规则模型，目前只支持账户立减"account"
        /// </summary>
        [JsonProperty("dst_camp_rule_model")]
        public DstCampRuleModel DstCampRuleModel { get; set; }

        /// <summary>
        /// 活动子时间，可以不传
        /// </summary>
        [JsonProperty("dst_camp_sub_time_model_list")]
        public List<DateAreaModel> DstCampSubTimeModelList { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [JsonProperty("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [JsonProperty("gmt_start")]
        public string GmtStart { get; set; }

        /// <summary>
        /// 新增传CAMP_ADD，修改传CAMP_MODIFIED
        /// </summary>
        [JsonProperty("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 奖品类型(支持4种):打折\满减\单笔减\随机立减  折扣方式     DISCOUNT("discount", "折扣"),     REDUCE("reduce", "满立减"),     SINGLE("single", "单笔减"),     RANDOM_DISCOUNT("random", "随机立减");
        /// </summary>
        [JsonProperty("prize_type")]
        public string PrizeType { get; set; }

        /// <summary>
        /// 随机立减模型如果类型选了random,则这个模型必须输入
        /// </summary>
        [JsonProperty("random_discount_dst_camp_prize_model")]
        public RandomDiscountDstCampPrizeModel RandomDiscountDstCampPrizeModel { get; set; }

        /// <summary>
        /// 满立减奖品模型 如果类型选了reduce,则这个模型必须输入
        /// </summary>
        [JsonProperty("reduce_dst_camp_prize_model")]
        public ReduceDstCampPrizeModel ReduceDstCampPrizeModel { get; set; }

        /// <summary>
        /// 订单金额减至模型如果类型选了reduce_to_discount,则这个模型必须输入
        /// </summary>
        [JsonProperty("reduce_to_discount_dst_camp_prize_model")]
        public ReduceToDiscountDstCampPrizeModel ReduceToDiscountDstCampPrizeModel { get; set; }

        /// <summary>
        /// 抹零优惠模型如果类型选了reset_zero_discount,则这个模型必须输入
        /// </summary>
        [JsonProperty("reset_zero_dst_camp_prize_model")]
        public ResetZeroDstCampPrizeModel ResetZeroDstCampPrizeModel { get; set; }

        /// <summary>
        /// 单笔减奖品模型如果类型选了single,则这个模型必须输入
        /// </summary>
        [JsonProperty("single_dst_camp_prize_model")]
        public SingleDstCampPrizeModel SingleDstCampPrizeModel { get; set; }

        /// <summary>
        /// 阶梯优惠如果类型选了staged_discount,则这个模型必须输入
        /// </summary>
        [JsonProperty("staged_discount_dst_camp_prize_model")]
        public StagedDiscountDstCampPrizeModel StagedDiscountDstCampPrizeModel { get; set; }
    }
}
