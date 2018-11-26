using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IntelligentPromoEffect Data Structure.
    /// </summary>
    [Serializable]
    public class IntelligentPromoEffect : AlipayObject
    {
        /// <summary>
        /// 平均客单价提升比例
        /// </summary>
        [JsonProperty("avg_prize_increase")]
        [XmlElement("avg_prize_increase")]
        public string AvgPrizeIncrease { get; set; }

        /// <summary>
        /// 成本
        /// </summary>
        [JsonProperty("cost")]
        [XmlElement("cost")]
        public string Cost { get; set; }

        /// <summary>
        /// 当前效益
        /// </summary>
        [JsonProperty("current_total_amount")]
        [XmlElement("current_total_amount")]
        public string CurrentTotalAmount { get; set; }

        /// <summary>
        /// 营销活动的预期效果id
        /// </summary>
        [JsonProperty("effect_id")]
        [XmlElement("effect_id")]
        public string EffectId { get; set; }

        /// <summary>
        /// 时间范围左值
        /// </summary>
        [JsonProperty("gmt_from")]
        [XmlElement("gmt_from")]
        public string GmtFrom { get; set; }

        /// <summary>
        /// 时间范围右值
        /// </summary>
        [JsonProperty("gmt_to")]
        [XmlElement("gmt_to")]
        public string GmtTo { get; set; }

        /// <summary>
        /// 成交额
        /// </summary>
        [JsonProperty("gmv")]
        [XmlElement("gmv")]
        public string Gmv { get; set; }

        /// <summary>
        /// 剩余库存数
        /// </summary>
        [JsonProperty("remain_stock_num")]
        [XmlElement("remain_stock_num")]
        public long RemainStockNum { get; set; }

        /// <summary>
        /// 复购率提升比例
        /// </summary>
        [JsonProperty("repay_rate_increase")]
        [XmlElement("repay_rate_increase")]
        public string RepayRateIncrease { get; set; }

        /// <summary>
        /// 发券量提升比例
        /// </summary>
        [JsonProperty("send_count_increase")]
        [XmlElement("send_count_increase")]
        public string SendCountIncrease { get; set; }

        /// <summary>
        /// 发券数量
        /// </summary>
        [JsonProperty("take_count")]
        [XmlElement("take_count")]
        public long TakeCount { get; set; }

        /// <summary>
        /// 营销活动效果类型。FORECAST：预估；STATISTICS：统计
        /// </summary>
        [JsonProperty("type")]
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 核销量
        /// </summary>
        [JsonProperty("use_count")]
        [XmlElement("use_count")]
        public long UseCount { get; set; }
    }
}
