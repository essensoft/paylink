using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTradeRepaybillModifyResponse.
    /// </summary>
    public class AlipayTradeRepaybillModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 当前账单的金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonPropertyName("bill_amount")]
        public string BillAmount { get; set; }

        /// <summary>
        /// 支付宝还款账单编号
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 账单逾期罚息金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonPropertyName("bill_overdue_amount")]
        public string BillOverdueAmount { get; set; }

        /// <summary>
        /// 账单支付部分撤销金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonPropertyName("bill_paid_revoked_amount")]
        public string BillPaidRevokedAmount { get; set; }

        /// <summary>
        /// 账单未支付部分已撤销金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonPropertyName("bill_revoked_amount")]
        public string BillRevokedAmount { get; set; }

        /// <summary>
        /// 账单状态
        /// </summary>
        [JsonPropertyName("bill_status")]
        public string BillStatus { get; set; }
    }
}
