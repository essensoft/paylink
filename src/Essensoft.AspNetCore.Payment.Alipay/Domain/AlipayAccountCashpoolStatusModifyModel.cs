using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAccountCashpoolStatusModifyModel Data Structure.
    /// </summary>
    public class AlipayAccountCashpoolStatusModifyModel : AlipayObject
    {
        /// <summary>
        /// 资金池状态，INITIAL/RUN/STOP
        /// </summary>
        [JsonPropertyName("adjust_status")]
        public string AdjustStatus { get; set; }

        /// <summary>
        /// 资金池ID
        /// </summary>
        [JsonPropertyName("cash_pool_id")]
        public string CashPoolId { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }
    }
}
