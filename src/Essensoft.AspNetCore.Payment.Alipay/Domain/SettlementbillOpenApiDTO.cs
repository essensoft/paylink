using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SettlementbillOpenApiDTO Data Structure.
    /// </summary>
    public class SettlementbillOpenApiDTO : AlipayObject
    {
        /// <summary>
        /// 外部的业务单据号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 结算单金额
        /// </summary>
        [JsonPropertyName("settle_amount")]
        public MultiCurrencyMoneyOpenApi SettleAmount { get; set; }

        /// <summary>
        /// 生成的结算单号
        /// </summary>
        [JsonPropertyName("settlement_bill_no")]
        public string SettlementBillNo { get; set; }
    }
}
