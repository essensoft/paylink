using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Activity Data Structure.
    /// </summary>
    [Serializable]
    public class Activity : AlipayObject
    {
        /// <summary>
        /// 活动名称，用于展示和区分活动，可重名
        /// </summary>
        [JsonProperty("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动号
        /// </summary>
        [JsonProperty("activity_no")]
        public string ActivityNo { get; set; }

        /// <summary>
        /// 芝麻信用承诺消费活动规则详情, 商户创建的活动规则, 无需脱敏。
        /// </summary>
        [JsonProperty("activity_rule_detail")]
        public ActivityRuleDetail ActivityRuleDetail { get; set; }

        /// <summary>
        /// 活动门店列表信息
        /// </summary>
        [JsonProperty("activity_shop_list")]
        public List<ActivityShop> ActivityShopList { get; set; }

        /// <summary>
        /// 活动统计信息, 查询如果打开开关就会有统计值
        /// </summary>
        [JsonProperty("activity_stat")]
        public ActivityStat ActivityStat { get; set; }

        /// <summary>
        /// 活动状态, 一定在下列枚举中：  NOT_STARTED - 未开始  AVAILABLE - 活动中  END - 活动结束
        /// </summary>
        [JsonProperty("activity_status")]
        public string ActivityStatus { get; set; }

        /// <summary>
        /// 活动品牌名称
        /// </summary>
        [JsonProperty("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 活动结束时间，标准时间格式：yyyy-MM-dd HH:mm:ss.
        /// </summary>
        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 消费维度，用于核销判断，必须在如下枚举中：  MERCHANT - 商户维度  SHOP - 门店维度
        /// </summary>
        [JsonProperty("fulfil_dimension")]
        public string FulfilDimension { get; set; }

        /// <summary>
        /// 开放平台接口调用者appId
        /// </summary>
        [JsonProperty("invoke_app_id")]
        public string InvokeAppId { get; set; }

        /// <summary>
        /// 商户外部活动号。需确保同一个商户Id下外部活动号唯一。
        /// </summary>
        [JsonProperty("out_activity_no")]
        public string OutActivityNo { get; set; }

        /// <summary>
        /// 商户Id
        /// </summary>
        [JsonProperty("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 活动规则类型，在如下枚内：  CONSUME_AMOUNT -- 消费金额;  CONSUME_TIMES -- 消费次数。
        /// </summary>
        [JsonProperty("rule_type")]
        public string RuleType { get; set; }

        /// <summary>
        /// 活动规则类型描述，在如下枚内：  CONSUME_AMOUNT为"消费金额";  CONSUME_TIMES为"消费次数"。
        /// </summary>
        [JsonProperty("rule_type_desc")]
        public string RuleTypeDesc { get; set; }

        /// <summary>
        /// 活动开始时间，请用标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("start_time")]
        public string StartTime { get; set; }
    }
}
