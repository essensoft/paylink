using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntfortuneEquityPortfolioQueryResponse.
    /// </summary>
    public class AntfortuneEquityPortfolioQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否可买入
        /// </summary>
        [JsonPropertyName("can_purchase")]
        public bool CanPurchase { get; set; }

        /// <summary>
        /// 是否可卖出
        /// </summary>
        [JsonPropertyName("can_sell")]
        public bool CanSell { get; set; }

        /// <summary>
        /// 组合成立日期
        /// </summary>
        [JsonPropertyName("established_date")]
        public string EstablishedDate { get; set; }

        /// <summary>
        /// 日涨跌幅，四舍五入后保留小数点后4位
        /// </summary>
        [JsonPropertyName("last_day_profit_rate")]
        public string LastDayProfitRate { get; set; }

        /// <summary>
        /// 近一年涨跌幅，四舍五入后保留小数点后4位
        /// </summary>
        [JsonPropertyName("latest_one_year_profit_rate")]
        public string LatestOneYearProfitRate { get; set; }

        /// <summary>
        /// 起购金额
        /// </summary>
        [JsonPropertyName("min_purchase_amount")]
        public string MinPurchaseAmount { get; set; }

        /// <summary>
        /// 组合产品代码
        /// </summary>
        [JsonPropertyName("portfolio_code")]
        public string PortfolioCode { get; set; }

        /// <summary>
        /// 组合明细
        /// </summary>
        [JsonPropertyName("portfolio_detail_products")]
        public List<PortfolioDetailProductInfo> PortfolioDetailProducts { get; set; }

        /// <summary>
        /// 组合名称，新建组合时候的命名
        /// </summary>
        [JsonPropertyName("portfolio_name")]
        public string PortfolioName { get; set; }

        /// <summary>
        /// 策略标签，英文逗号分隔
        /// </summary>
        [JsonPropertyName("portfolio_tag_list")]
        public List<string> PortfolioTagList { get; set; }

        /// <summary>
        /// 组合类型 ("STEADY_PORTFOLIO", "稳健组合"), ("MONETARY_BONDS_PORTFOLIO","货债组合"), ("ASSET_CONFIG", "资产配置"), ("GLOBAL_CONFIG", "全球配置 "), ("GOAL_RISK", "目标风险"), ("SELECTED_PRODUCT_PORTFOLIO", "精选产品组合"), ("SELECTED_TIME_STRATEGY", "择时策略"), ("ROTATION_STRATEGY", "轮动策略")
        /// </summary>
        [JsonPropertyName("portfolio_type")]
        public string PortfolioType { get; set; }

        /// <summary>
        /// 组合ID
        /// </summary>
        [JsonPropertyName("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 收益率类型，("last_week", "近1周"),"last_month", "近1月"),("last_quarter", "近3月"),("last_half_year", "近半年"),("this_year", "今年"),("last_year", "近1年"),("yield_2_year", "近2年"),("yield_3_year", "近3年"),("yield_5_year", "近5年"),("NETVALUE", "产品净值"),("SINCE_ESTABLISHMENT", "成立以来")
        /// </summary>
        [JsonPropertyName("profit_period_key")]
        public string ProfitPeriodKey { get; set; }

        /// <summary>
        /// 收益率，对应区间段类型，返回结果四舍五入后保留小数点后4位
        /// </summary>
        [JsonPropertyName("profit_rate")]
        public string ProfitRate { get; set; }

        /// <summary>
        /// 组合产品风险等级,L(低风险),ML(中低风险),M(中风险),MH(中高风险),H(高风险)
        /// </summary>
        [JsonPropertyName("risk_evaluation")]
        public string RiskEvaluation { get; set; }

        /// <summary>
        /// 主理人Code，对于机构类型的主理人来说即为instId
        /// </summary>
        [JsonPropertyName("sp_code")]
        public string SpCode { get; set; }

        /// <summary>
        /// 主理人ID
        /// </summary>
        [JsonPropertyName("sp_id")]
        public string SpId { get; set; }

        /// <summary>
        /// 主理人介绍
        /// </summary>
        [JsonPropertyName("sp_intro")]
        public string SpIntro { get; set; }

        /// <summary>
        /// 主理人logo
        /// </summary>
        [JsonPropertyName("sp_logo")]
        public string SpLogo { get; set; }

        /// <summary>
        /// 主理人名称
        /// </summary>
        [JsonPropertyName("sp_name")]
        public string SpName { get; set; }

        /// <summary>
        /// 主理人类型，包括 ANT_PLATFORM（蚂蚁平台）、VERIFIED_INST（机构）、VERIFIED_PERSON（个人）
        /// </summary>
        [JsonPropertyName("sp_type")]
        public string SpType { get; set; }

        /// <summary>
        /// 策略目标
        /// </summary>
        [JsonPropertyName("strategy_goal")]
        public string StrategyGoal { get; set; }

        /// <summary>
        /// 组合简介
        /// </summary>
        [JsonPropertyName("strategy_intro")]
        public string StrategyIntro { get; set; }

        /// <summary>
        /// 策略描述地址
        /// </summary>
        [JsonPropertyName("strategy_url")]
        public string StrategyUrl { get; set; }

        /// <summary>
        /// 建议持有时间，有效值包括ABOVE_SEVEN_DAY(七天以上),ONE_THREE_MONTH(一到三个月),THREE_SIX_MONTH(三到六个月),SIX_TWELVE_MONTH(六到十二个月),ONE_TWO_YEAR(一到两年),TWO_FIVE_YEAR(两到五年),FIVE_ABOVE_YEAR(五年以上)
        /// </summary>
        [JsonPropertyName("suggested_keep_period")]
        public string SuggestedKeepPeriod { get; set; }
    }
}
