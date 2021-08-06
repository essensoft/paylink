using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ApplyBasicInfo Data Structure.
    /// </summary>
    public class ApplyBasicInfo : AlipayObject
    {
        /// <summary>
        /// 保额
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 投保人信息
        /// </summary>
        [JsonPropertyName("apply_info")]
        public InsurancePersonInfo ApplyInfo { get; set; }

        /// <summary>
        /// 受益人信息
        /// </summary>
        [JsonPropertyName("beneficiary_info")]
        public InsurancePersonInfo BeneficiaryInfo { get; set; }

        /// <summary>
        /// 保险条款信息
        /// </summary>
        [JsonPropertyName("insurance_clause")]
        public InsuranceClauseInfo InsuranceClause { get; set; }

        /// <summary>
        /// 保险止期
        /// </summary>
        [JsonPropertyName("insure_end_date")]
        public string InsureEndDate { get; set; }

        /// <summary>
        /// 保险起期
        /// </summary>
        [JsonPropertyName("insure_start_date")]
        public string InsureStartDate { get; set; }

        /// <summary>
        /// 被保人信息
        /// </summary>
        [JsonPropertyName("insured_info")]
        public InsurancePersonInfo InsuredInfo { get; set; }

        /// <summary>
        /// 保费
        /// </summary>
        [JsonPropertyName("premium")]
        public string Premium { get; set; }

        /// <summary>
        /// 费率，最多兼容9位小数
        /// </summary>
        [JsonPropertyName("rate")]
        public string Rate { get; set; }

        /// <summary>
        /// 关联业务订单号
        /// </summary>
        [JsonPropertyName("related_order_no")]
        public string RelatedOrderNo { get; set; }
    }
}
