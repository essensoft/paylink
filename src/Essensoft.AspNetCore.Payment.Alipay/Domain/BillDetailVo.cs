using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BillDetailVo Data Structure.
    /// </summary>
    public class BillDetailVo : AlipayObject
    {
        /// <summary>
        /// 账单出账时间
        /// </summary>
        [JsonPropertyName("bill_account_date")]
        public string BillAccountDate { get; set; }

        /// <summary>
        /// 账单余额明细
        /// </summary>
        [JsonPropertyName("bill_balance_detail")]
        public BillAmtVo BillBalanceDetail { get; set; }

        /// <summary>
        /// 账单创建时间
        /// </summary>
        [JsonPropertyName("bill_create_date")]
        public string BillCreateDate { get; set; }

        /// <summary>
        /// 账单编号
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 账单已还明细
        /// </summary>
        [JsonPropertyName("bill_repay_detail")]
        public BillAmtVo BillRepayDetail { get; set; }

        /// <summary>
        /// 账单状态，NOR正常，OVD逾期，CLE结清
        /// </summary>
        [JsonPropertyName("bill_status")]
        public string BillStatus { get; set; }

        /// <summary>
        /// 账单结清时间
        /// </summary>
        [JsonPropertyName("clear_date")]
        public string ClearDate { get; set; }

        /// <summary>
        /// 账单还款日
        /// </summary>
        [JsonPropertyName("repay_date")]
        public string RepayDate { get; set; }

        /// <summary>
        /// 账单本金总额
        /// </summary>
        [JsonPropertyName("total_prin_amt")]
        public MultiCurrencyMoneyVO TotalPrinAmt { get; set; }
    }
}
