using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditLoantradePartnerPaymentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoantradePartnerPaymentQueryModel : AlipayObject
    {
        /// <summary>
        /// 网商内部申请单编号，外部机构根据此编号查询申请状态。
        /// </summary>
        [JsonProperty("in_apply_no")]
        public string InApplyNo { get; set; }
    }
}
