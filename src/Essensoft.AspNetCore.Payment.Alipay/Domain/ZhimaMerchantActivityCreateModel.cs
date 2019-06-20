using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaMerchantActivityCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantActivityCreateModel : AlipayObject
    {
        /// <summary>
        /// 活动名称，用于展示和区分活动，最大长度30
        /// </summary>
        [JsonProperty("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 芝麻信用承诺消费活动规则详情
        /// </summary>
        [JsonProperty("activity_rule_detail")]
        public ActivityRuleDetail ActivityRuleDetail { get; set; }

        /// <summary>
        /// 活动门店列表信息
        /// </summary>
        [JsonProperty("activity_shops")]
        public List<ActivityShop> ActivityShops { get; set; }

        /// <summary>
        /// 活动品牌名称
        /// </summary>
        [JsonProperty("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 芝麻信用授权评估所需类目, 支持如下类目：  LAUNDRY - 洗衣  PARENT_CHILD - 亲子  PHOTOGRAPHY - 摄影  MARRY - 结婚  PET - 宠物  WORK_OUT - 运动健身  BEAUTY - 美发/美容/美甲  ENTERTAINMENT - 休闲娱乐  KTV - K歌  SUPERMARKET - 超市便利店  BOOKSTORE - 书店  SKILLS_TRAINING - 技能培训  SHOPPING - 购物  CAR - 爱车  DOMESTIC_SERVICES - 生活服务  SHOPPING_MALL - 商圈综合体  MEDICAL_HEALTH - 医疗健康  TRAVEL - 航旅  SALES - 专业销售/批发  SOCIAL_ORGANIZATION - 政府/社会组织  MOVIE - 电影  FOOD - 美食
        /// </summary>
        [JsonProperty("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 活动结束时间，标准时间格式：yyyy-MM-dd HH:mm:ss，活动结束时间不能早于当前时间。
        /// </summary>
        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 消费维度，用于核销判断，必须在如下枚举中：  MERCHANT - 商户维度  SHOP - 门店维度
        /// </summary>
        [JsonProperty("fulfil_dimension")]
        public string FulfilDimension { get; set; }

        /// <summary>
        /// 商户外部活动号。需确保同一个商户Id下外部活动号唯一。
        /// </summary>
        [JsonProperty("out_activity_no")]
        public string OutActivityNo { get; set; }

        /// <summary>
        /// 商户优惠退回账户，必须是商户的实名认证的支付宝账号，未实名认证会拦截。
        /// </summary>
        [JsonProperty("payback_account")]
        public string PaybackAccount { get; set; }

        /// <summary>
        /// 活动规则类型，必须在如下枚举内："CONSUME_AMOUNT"为"消费金额";"CONSUME_TIMES"为"消费次数"。
        /// </summary>
        [JsonProperty("rule_type")]
        public string RuleType { get; set; }

        /// <summary>
        /// 活动开始时间，请用标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("start_time")]
        public string StartTime { get; set; }
    }
}
