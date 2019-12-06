using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CreditPayInstallmentDetailVO Data Structure.
    /// </summary>
    public class CreditPayInstallmentDetailVO : AlipayObject
    {
        /// <summary>
        /// 费用详情列表，部分分期方案可能不存在费用
        /// </summary>
        [JsonPropertyName("charge_pricing_list")]
        public List<CreditPayChargePricingVO> ChargePricingList { get; set; }

        /// <summary>
        /// 条款列表，条款信息不是必定存在的
        /// </summary>
        [JsonPropertyName("clauses")]
        public List<CreditPayClauseVO> Clauses { get; set; }

        /// <summary>
        /// 优惠信息，部分分期方案可能不存在营销信息
        /// </summary>
        [JsonPropertyName("discount_info")]
        public CreditPayDiscountVO DiscountInfo { get; set; }

        /// <summary>
        /// 分期间隔
        /// </summary>
        [JsonPropertyName("instal_itrv")]
        public string InstalItrv { get; set; }

        /// <summary>
        /// 分期间隔类型，年月日(YMD)
        /// </summary>
        [JsonPropertyName("instal_type")]
        public string InstalType { get; set; }

        /// <summary>
        /// 分期ID
        /// </summary>
        [JsonPropertyName("installment_id")]
        public string InstallmentId { get; set; }

        /// <summary>
        /// 利息详情，部分分期方案可能不存在利息
        /// </summary>
        [JsonPropertyName("int_pricing")]
        public CreditPayIntPricingVO IntPricing { get; set; }

        /// <summary>
        /// 渲染模式，INTREST-利息版，INT_RATE-利率版
        /// </summary>
        [JsonPropertyName("render_strategy")]
        public string RenderStrategy { get; set; }

        /// <summary>
        /// 还款信息
        /// </summary>
        [JsonPropertyName("repay_info")]
        public CreditPayRepayVO RepayInfo { get; set; }

        /// <summary>
        /// 分期产品码
        /// </summary>
        [JsonPropertyName("sale_pd_code")]
        public string SalePdCode { get; set; }

        /// <summary>
        /// 分期签名，用于标识一组分期方案中唯一的期限信息,组成方式为sale_pd_code^repay_mode^term^term_unit
        /// </summary>
        [JsonPropertyName("scheme_sign")]
        public string SchemeSign { get; set; }

        /// <summary>
        /// 期限信息
        /// </summary>
        [JsonPropertyName("term_info")]
        public CreditPayTermVO TermInfo { get; set; }
    }
}
