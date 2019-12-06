using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ConstraintInfo Data Structure.
    /// </summary>
    public class ConstraintInfo : AlipayObject
    {
        /// <summary>
        /// 资金池ID  （数据来源：需要ISV自己去口碑销售中台创建资金池，拿到对应的资金池ID，此参数仅适用ISV接入口福业务场景时使用，其他场景不需要传递此参数）
        /// </summary>
        [JsonPropertyName("cash_pool_id")]
        public string CashPoolId { get; set; }

        /// <summary>
        /// 人群规则组ID  仅直发奖类型活动设置有效，通过调用营销活动人群组规则创建接口参数返回
        /// </summary>
        [JsonPropertyName("crowd_group_id")]
        public string CrowdGroupId { get; set; }

        /// <summary>
        /// 针对指定人群的约束条件
        /// </summary>
        [JsonPropertyName("crowd_restriction")]
        public string CrowdRestriction { get; set; }

        /// <summary>
        /// 根据crowd_restriction的值不同，设置相应的值，如果crowd_restriction是“MEMBER_CARD”，crowd_restriction_value就是关联会员卡模版ID集合，用逗号拼接
        /// </summary>
        [JsonPropertyName("crowd_restriction_value")]
        public string CrowdRestrictionValue { get; set; }

        /// <summary>
        /// 单品码列表  仅在创建消费单品送活动时设置，最多设置500个单品码,由商户根据自己的商品管理自定义，一般为国标码
        /// </summary>
        [JsonPropertyName("item_ids")]
        public List<string> ItemIds { get; set; }

        /// <summary>
        /// 最低消费金额，单位元  仅在创建消费送礼包活动时设置
        /// </summary>
        [JsonPropertyName("min_cost")]
        public string MinCost { get; set; }

        /// <summary>
        /// 补贴百分比,95表示 95%，支持两位小数  （参数说明：补贴比例95%，表示ISV出资95%，商户出资5%，此参数仅适用ISV接入口福业务场景时使用，其他场景不需要传递此参数）
        /// </summary>
        [JsonPropertyName("subsidy_percent")]
        public string SubsidyPercent { get; set; }

        /// <summary>
        /// 活动适用的门店列表  仅品牌商发起的招商活动可为空  最多支持10w家门店
        /// </summary>
        [JsonPropertyName("suit_shops")]
        public List<string> SuitShops { get; set; }

        /// <summary>
        /// 活动期间用户能够参与的次数限制  如果不设置则不限制参与次数
        /// </summary>
        [JsonPropertyName("user_win_count")]
        public string UserWinCount { get; set; }

        /// <summary>
        /// 活动期间用户能够参与的频率限制  如果不设置则不限制参与频率  每日中奖1次: D||1   每周中奖2次: W||2   每月中奖3次: M||3
        /// </summary>
        [JsonPropertyName("user_win_frequency")]
        public string UserWinFrequency { get; set; }
    }
}
