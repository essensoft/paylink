using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DrawndnVo Data Structure.
    /// </summary>
    public class DrawndnVo : AlipayObject
    {
        /// <summary>
        /// 实收利息，单位为元，小数点保留2位
        /// </summary>
        [JsonPropertyName("actual_collected_interest")]
        public string ActualCollectedInterest { get; set; }

        /// <summary>
        /// 贷款余额(本金余额)
        /// </summary>
        [JsonPropertyName("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 已收本息，单位为元，小数点保留2位
        /// </summary>
        [JsonPropertyName("collected_principal_and_interest")]
        public string CollectedPrincipalAndInterest { get; set; }

        /// <summary>
        /// 授信编号
        /// </summary>
        [JsonPropertyName("credit_no")]
        public string CreditNo { get; set; }

        /// <summary>
        /// 支用日,这里代表的是客户这笔支用放款成功日期，如果支用还在放款中或者支用放款失败等，则该值为空
        /// </summary>
        [JsonPropertyName("drawndn_date")]
        public string DrawndnDate { get; set; }

        /// <summary>
        /// 支用编号，代表一笔支用的唯一编号
        /// </summary>
        [JsonPropertyName("drawndn_no")]
        public string DrawndnNo { get; set; }

        /// <summary>
        /// 到期日
        /// </summary>
        [JsonPropertyName("due_date")]
        public string DueDate { get; set; }

        /// <summary>
        /// 五级分类，值类型：NORMAL（正常）、ATTENTION（关注）、SUBPRIME（次级）、DOUBTFUL（可疑）、LOSSES（损失）
        /// </summary>
        [JsonPropertyName("five_tier_classification")]
        public string FiveTierClassification { get; set; }

        /// <summary>
        /// 正常利息，单位为元，小数点保留2位
        /// </summary>
        [JsonPropertyName("interest")]
        public string Interest { get; set; }

        /// <summary>
        /// 年利率，小数点保留2位
        /// </summary>
        [JsonPropertyName("interest_rate")]
        public string InterestRate { get; set; }

        /// <summary>
        /// 贷款发放额，单位为元，小数点保留2位
        /// </summary>
        [JsonPropertyName("lending_amount")]
        public string LendingAmount { get; set; }

        /// <summary>
        /// 当前逾期期次
        /// </summary>
        [JsonPropertyName("overduce_terms")]
        public long OverduceTerms { get; set; }

        /// <summary>
        /// 当前逾期天数
        /// </summary>
        [JsonPropertyName("overdue_days")]
        public long OverdueDays { get; set; }

        /// <summary>
        /// 逾期利息，单位为元，小数点保留2位
        /// </summary>
        [JsonPropertyName("overdue_interest")]
        public string OverdueInterest { get; set; }

        /// <summary>
        /// 逾期利息罚息，单位为元，小数点保留2位
        /// </summary>
        [JsonPropertyName("overdue_interest_penalty")]
        public string OverdueInterestPenalty { get; set; }

        /// <summary>
        /// 逾期本金，单位为元，小数点保留2位
        /// </summary>
        [JsonPropertyName("overdue_principal")]
        public string OverduePrincipal { get; set; }

        /// <summary>
        /// 逾期本金罚息，单位为元，小数点保留2位
        /// </summary>
        [JsonPropertyName("overdue_principal_penalty")]
        public string OverduePrincipalPenalty { get; set; }

        /// <summary>
        /// 支用状态 ,值类型：INIT(初始),LENDING(发放中),NORMAL(正常),OVD(逾期), CLEAR(结清),OFF(核销), LENDFAIL(发放失败)
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
