using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IntelligentPromoEffect Data Structure.
    /// </summary>
    public class IntelligentPromoEffect : AlipayObject
    {
        /// <summary>
        /// 平均客单价提升比例
        /// </summary>
        [JsonPropertyName("avg_prize_increase")]
        public string AvgPrizeIncrease { get; set; }

        /// <summary>
        /// 成本
        /// </summary>
        [JsonPropertyName("cost")]
        public string Cost { get; set; }

        /// <summary>
        /// 当前效益
        /// </summary>
        [JsonPropertyName("current_total_amount")]
        public string CurrentTotalAmount { get; set; }

        /// <summary>
        /// 营销活动的预期效果id
        /// </summary>
        [JsonPropertyName("effect_id")]
        public string EffectId { get; set; }

        /// <summary>
        /// 时间范围左值
        /// </summary>
        [JsonPropertyName("gmt_from")]
        public string GmtFrom { get; set; }

        /// <summary>
        /// 时间范围右值
        /// </summary>
        [JsonPropertyName("gmt_to")]
        public string GmtTo { get; set; }

        /// <summary>
        /// 成交额
        /// </summary>
        [JsonPropertyName("gmv")]
        public string Gmv { get; set; }

        /// <summary>
        /// 剩余库存数
        /// </summary>
        [JsonPropertyName("remain_stock_num")]
        public long RemainStockNum { get; set; }

        /// <summary>
        /// 复购率提升比例
        /// </summary>
        [JsonPropertyName("repay_rate_increase")]
        public string RepayRateIncrease { get; set; }

        /// <summary>
        /// 发券量提升比例
        /// </summary>
        [JsonPropertyName("send_count_increase")]
        public string SendCountIncrease { get; set; }

        /// <summary>
        /// 发券数量
        /// </summary>
        [JsonPropertyName("take_count")]
        public long TakeCount { get; set; }

        /// <summary>
        /// 营销活动效果类型。FORECAST：预估；STATISTICS：统计
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 核销量
        /// </summary>
        [JsonPropertyName("use_count")]
        public long UseCount { get; set; }
    }
}
