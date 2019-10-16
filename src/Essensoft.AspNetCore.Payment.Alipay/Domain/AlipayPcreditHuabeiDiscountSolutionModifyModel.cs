using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiDiscountSolutionModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiDiscountSolutionModifyModel : AlipayObject
    {
        /// <summary>
        /// 花呗分期商家贴息活动名称，长度不能超过30个汉字或字符
        /// </summary>
        [JsonProperty("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// amount_budget，花呗分期贴息预算金额，单位是元
        /// </summary>
        [JsonProperty("amount_budget")]
        public string AmountBudget { get; set; }

        /// <summary>
        /// budget_warning_mail_list，预算提醒邮件列表，邮箱必须符合邮箱地址规则，提醒邮箱个数不能超过5个
        /// </summary>
        [JsonProperty("budget_warning_mail_list")]
        public List<string> BudgetWarningMailList { get; set; }

        /// <summary>
        /// budget_warning_mobile_no_list，预算提醒手机号列表，符合手机号码规则，提醒手机号个数不能超过5个
        /// </summary>
        [JsonProperty("budget_warning_mobile_no_list")]
        public List<string> BudgetWarningMobileNoList { get; set; }

        /// <summary>
        /// budget_warning_money，预算提醒金额，不能高于预算金额，预算达到该金额时会触发告警通知，单位是元。
        /// </summary>
        [JsonProperty("budget_warning_money")]
        public string BudgetWarningMoney { get; set; }

        /// <summary>
        /// end_time，活动结束时间，必须大于start_time，且结束时间必须晚于当前时间
        /// </summary>
        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// install_num_str_list，花呗分期数集合，不同期数之间用逗号分开
        /// </summary>
        [JsonProperty("install_num_str_list")]
        public List<string> InstallNumStrList { get; set; }

        /// <summary>
        /// max_money_limit，免息金额上限不能大于300000, 不能低于免息金额下限，交易额度若高于该上限值则不做花呗分期免息补贴，单位是元
        /// </summary>
        [JsonProperty("max_money_limit")]
        public string MaxMoneyLimit { get; set; }

        /// <summary>
        /// min_money_limit，免息金额下限不能少于100，交易额度若小于该值，则不做花呗分期免息补贴，单位是元。
        /// </summary>
        [JsonProperty("min_money_limit")]
        public string MinMoneyLimit { get; set; }

        /// <summary>
        /// solution_id，贴息方案id，更新时传值不能为空
        /// </summary>
        [JsonProperty("solution_id")]
        public long SolutionId { get; set; }

        /// <summary>
        /// start_time，活动开始时间
        /// </summary>
        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// sub_shop_info, 子门店信息，间连贴息商家、海外商家该字段必须要填写，其他选填！
        /// </summary>
        [JsonProperty("sub_shop_info")]
        public SubShopInfo SubShopInfo { get; set; }
    }
}
