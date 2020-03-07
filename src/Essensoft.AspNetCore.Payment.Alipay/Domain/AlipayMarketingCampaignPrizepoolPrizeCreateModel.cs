using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignPrizepoolPrizeCreateModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignPrizepoolPrizeCreateModel : AlipayObject
    {
        /// <summary>
        /// 当预算类型是数量时，该值表示个数 当预算类型是金额时，该值表示金额，(分)为单位
        /// </summary>
        [JsonPropertyName("budget_amount")]
        public string BudgetAmount { get; set; }

        /// <summary>
        /// COUNT 数量预算 MONEY 金额预算
        /// </summary>
        [JsonPropertyName("budget_type")]
        public string BudgetType { get; set; }

        /// <summary>
        /// 计次配置，具体字段参考CountControlConfig
        /// </summary>
        [JsonPropertyName("count_control_config")]
        public List<CountControlConfig> CountControlConfig { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [JsonPropertyName("ext_properties")]
        public string ExtProperties { get; set; }

        /// <summary>
        /// 奖品发放开始时间
        /// </summary>
        [JsonPropertyName("gmt_begin")]
        public string GmtBegin { get; set; }

        /// <summary>
        /// 奖品发放结束时间
        /// </summary>
        [JsonPropertyName("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 单次发放系数，默认值1
        /// </summary>
        [JsonPropertyName("modulus")]
        public long Modulus { get; set; }

        /// <summary>
        /// 外部业务流水号，用来标识唯一的业务动作，用于，幂等
        /// </summary>
        [JsonPropertyName("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 奖品owner，填写支付宝2088账号
        /// </summary>
        [JsonPropertyName("owner")]
        public string Owner { get; set; }

        /// <summary>
        /// 奖品池id，使用前请联系业务对接同学提供
        /// </summary>
        [JsonPropertyName("pool_id")]
        public string PoolId { get; set; }

        /// <summary>
        /// 奖品名称
        /// </summary>
        [JsonPropertyName("prize_name")]
        public string PrizeName { get; set; }

        /// <summary>
        /// 奖品定价策略,具体见PrizePriceStategy字段
        /// </summary>
        [JsonPropertyName("prize_price_strategy")]
        public PrizePriceStrategy PrizePriceStrategy { get; set; }

        /// <summary>
        /// 子奖品类型，在同一种奖品类型下具体系分不同子类型，具体值联系营销技术获取
        /// </summary>
        [JsonPropertyName("prize_sub_type")]
        public string PrizeSubType { get; set; }

        /// <summary>
        /// 奖品类型，具体值联系营销技术提供，枚举类com.alipay.promokernel.common.service.facade.enums.PrizeTypeEnum
        /// </summary>
        [JsonPropertyName("prize_type")]
        public string PrizeType { get; set; }

        /// <summary>
        /// 表示业务来源，由营销技术提供具体值
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// 奖品模板参数，外部奖品的券模板之类的配置信息，用于创建奖品
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
