using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ResourceDataVO Data Structure.
    /// </summary>
    public class ResourceDataVO : AlipayObject
    {
        /// <summary>
        /// 人均访问停留时长（ms） 聚合天数为多天时，则为日均指标
        /// </summary>
        [JsonPropertyName("avg_stay_duration_per_user")]
        public string AvgStayDurationPerUser { get; set; }

        /// <summary>
        /// 次均访问停留时长（ms) 聚合天数为多天时，则为日均指标
        /// </summary>
        [JsonPropertyName("avg_stay_duration_per_vst")]
        public string AvgStayDurationPerVst { get; set; }

        /// <summary>
        /// 插件内容点击次数
        /// </summary>
        [JsonPropertyName("clk_cnt")]
        public long ClkCnt { get; set; }

        /// <summary>
        /// 插件内容点击去重用户数量
        /// </summary>
        [JsonPropertyName("clk_user_cnt")]
        public long ClkUserCnt { get; set; }

        /// <summary>
        /// 插件日分佣金额
        /// </summary>
        [JsonPropertyName("commission")]
        public string Commission { get; set; }

        /// <summary>
        /// PV分佣额产值
        /// </summary>
        [JsonPropertyName("commission_per_pv")]
        public string CommissionPerPv { get; set; }

        /// <summary>
        /// UV分佣额产值
        /// </summary>
        [JsonPropertyName("commission_per_uv")]
        public string CommissionPerUv { get; set; }

        /// <summary>
        /// 插件内容曝光次数
        /// </summary>
        [JsonPropertyName("expo_cnt")]
        public long ExpoCnt { get; set; }

        /// <summary>
        /// 插件内容曝光去重用户数量
        /// </summary>
        [JsonPropertyName("expo_user_cnt")]
        public long ExpoUserCnt { get; set; }

        /// <summary>
        /// 成交金额
        /// </summary>
        [JsonPropertyName("order_gmv")]
        public string OrderGmv { get; set; }

        /// <summary>
        /// 推广位名称
        /// </summary>
        [JsonPropertyName("origin_name")]
        public string OriginName { get; set; }

        /// <summary>
        /// 推广位ID1
        /// </summary>
        [JsonPropertyName("platform_promotion_id")]
        public string PlatformPromotionId { get; set; }

        /// <summary>
        /// 插件内容点击量转化率
        /// </summary>
        [JsonPropertyName("pv_rate")]
        public string PvRate { get; set; }

        /// <summary>
        /// 数据统计时间
        /// </summary>
        [JsonPropertyName("report_date")]
        public string ReportDate { get; set; }

        /// <summary>
        /// 插件日销售笔数
        /// </summary>
        [JsonPropertyName("trade_cnt")]
        public string TradeCnt { get; set; }

        /// <summary>
        /// PV销售额产值
        /// </summary>
        [JsonPropertyName("trade_gmv_per_pv")]
        public string TradeGmvPerPv { get; set; }

        /// <summary>
        /// UV销售额产值
        /// </summary>
        [JsonPropertyName("trade_gmv_per_uv")]
        public string TradeGmvPerUv { get; set; }

        /// <summary>
        /// 插件内容点击用户转化率
        /// </summary>
        [JsonPropertyName("uv_rate")]
        public string UvRate { get; set; }

        /// <summary>
        /// 插件访问次数
        /// </summary>
        [JsonPropertyName("vst_cnt")]
        public long VstCnt { get; set; }

        /// <summary>
        /// 插件访问去重用户数量
        /// </summary>
        [JsonPropertyName("vst_user_cnt")]
        public long VstUserCnt { get; set; }
    }
}
