using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTradeRepaybillQueryResponse.
    /// </summary>
    public class AlipayTradeRepaybillQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前账单的金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonPropertyName("bill_amount")]
        public string BillAmount { get; set; }

        /// <summary>
        /// 支付宝账单编号
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 账单逾期罚息金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonPropertyName("bill_overdue_amount")]
        public string BillOverdueAmount { get; set; }

        /// <summary>
        /// 账单已经支付金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonPropertyName("bill_paid_amount")]
        public string BillPaidAmount { get; set; }

        /// <summary>
        /// 支付后撤销金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonPropertyName("bill_paid_revoked_amount")]
        public string BillPaidRevokedAmount { get; set; }

        /// <summary>
        /// 账单支付前撤销金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonPropertyName("bill_revoked_amount")]
        public string BillRevokedAmount { get; set; }

        /// <summary>
        /// 账单对应状态，INIT：账单已入账；VALID：账单已出账；OVERDUE：账单已逾期；CLEAR：账单已结清
        /// </summary>
        [JsonPropertyName("bill_status")]
        public string BillStatus { get; set; }
    }
}
