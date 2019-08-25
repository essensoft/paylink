using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CreditPayAssetBaseVO Data Structure.
    /// </summary>
    [Serializable]
    public class CreditPayAssetBaseVO : AlipayObject
    {
        /// <summary>
        /// 可用额度，部分场景可能会被过滤不透出
        /// </summary>
        [JsonProperty("available_amt")]
        public CreditPayMoneyVO AvailableAmt { get; set; }

        /// <summary>
        /// 是否足额（可贷额度cover申请金额），true-足额，false-不足额
        /// </summary>
        [JsonProperty("credit_enough")]
        public bool CreditEnough { get; set; }

        /// <summary>
        /// 资产是否可用
        /// </summary>
        [JsonProperty("enable")]
        public bool Enable { get; set; }

        /// <summary>
        /// 资产名称-贷款支付，赊呗
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 提前还款文案
        /// </summary>
        [JsonProperty("pre_repay_desc")]
        public string PreRepayDesc { get; set; }

        /// <summary>
        /// 拒绝信息，只有在enable为false的时候才有值
        /// </summary>
        [JsonProperty("refuse_info")]
        public CreditPayRefuseVO RefuseInfo { get; set; }

        /// <summary>
        /// 还款日文案
        /// </summary>
        [JsonProperty("repay_day_desc")]
        public string RepayDayDesc { get; set; }

        /// <summary>
        /// 方案输出日期
        /// </summary>
        [JsonProperty("scheme_date")]
        public string SchemeDate { get; set; }

        /// <summary>
        /// 方案id
        /// </summary>
        [JsonProperty("scheme_id")]
        public string SchemeId { get; set; }

        /// <summary>
        /// 授信额度，部分场景可能会被过滤不透出
        /// </summary>
        [JsonProperty("total_amt")]
        public CreditPayMoneyVO TotalAmt { get; set; }

        /// <summary>
        /// 资产类型，LOAN_INSTALLMENT-贷款分期，BILL-账单
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
