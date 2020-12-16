using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncSettleSettlementbillCancelModel Data Structure.
    /// </summary>
    public class AlipayBossFncSettleSettlementbillCancelModel : AlipayObject
    {
        /// <summary>
        /// 取消金额  该金额等于结算单的金额 用于校验   不支持部分取消
        /// </summary>
        [JsonPropertyName("cancel_amount")]
        public MultiCurrencyMoneyOpenApi CancelAmount { get; set; }

        /// <summary>
        /// 外部业务单据号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 对应单据创建的来源 （系统名）
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }
    }
}
