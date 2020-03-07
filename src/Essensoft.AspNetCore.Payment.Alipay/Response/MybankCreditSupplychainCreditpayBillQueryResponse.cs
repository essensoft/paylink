using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditSupplychainCreditpayBillQueryResponse.
    /// </summary>
    public class MybankCreditSupplychainCreditpayBillQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 余额总金额
        /// </summary>
        [JsonPropertyName("balance_amt")]
        public string BalanceAmt { get; set; }

        /// <summary>
        /// 余额罚息金额
        /// </summary>
        [JsonPropertyName("balance_int_amt")]
        public string BalanceIntAmt { get; set; }

        /// <summary>
        /// 余额本金金额
        /// </summary>
        [JsonPropertyName("balance_prin_amt")]
        public string BalancePrinAmt { get; set; }

        /// <summary>
        /// 入账金额
        /// </summary>
        [JsonPropertyName("bill_amt")]
        public string BillAmt { get; set; }

        /// <summary>
        /// 出账日期
        /// </summary>
        [JsonPropertyName("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// 账单罚息金额
        /// </summary>
        [JsonPropertyName("bill_int_amt")]
        public string BillIntAmt { get; set; }

        /// <summary>
        /// 账单本金金额
        /// </summary>
        [JsonPropertyName("bill_prin_amt")]
        public string BillPrinAmt { get; set; }

        /// <summary>
        /// 买方信息，这里是ISV的信息
        /// </summary>
        [JsonPropertyName("buyer")]
        public Member Buyer { get; set; }

        /// <summary>
        /// 1688买家ID
        /// </summary>
        [JsonPropertyName("buyer_scene_id")]
        public string BuyerSceneId { get; set; }

        /// <summary>
        /// 账单状态：NOR/CLR/OVD
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 网商日志ID
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
