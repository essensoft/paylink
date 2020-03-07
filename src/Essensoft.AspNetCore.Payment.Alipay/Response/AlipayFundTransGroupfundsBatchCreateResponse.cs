using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFundTransGroupfundsBatchCreateResponse.
    /// </summary>
    public class AlipayFundTransGroupfundsBatchCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 团体资金批次号,后续业务流水以及预付款业务透传
        /// </summary>
        [JsonPropertyName("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 当前批次创建者所关联的资金单据
        /// </summary>
        [JsonPropertyName("current_fund_bill")]
        public GroupFundBill CurrentFundBill { get; set; }

        /// <summary>
        /// 当前批次对应的所有资金单据
        /// </summary>
        [JsonPropertyName("fund_bills")]
        public List<GroupFundBill> FundBills { get; set; }
    }
}
