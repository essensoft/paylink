using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MultiStagePayInfo Data Structure.
    /// </summary>
    public class MultiStagePayInfo : AlipayObject
    {
        /// <summary>
        /// 按月均匀支付:PAY_MONTHLY
        /// </summary>
        [JsonPropertyName("payment_mode")]
        public string PaymentMode { get; set; }

        /// <summary>
        /// 每期的支付信息的列表
        /// </summary>
        [JsonPropertyName("stage_lines")]
        public List<MultiStagePayLineInfo> StageLines { get; set; }

        /// <summary>
        /// 总支付金额，单位为元，最多小数点后面2位
        /// </summary>
        [JsonPropertyName("total_payment_amount")]
        public string TotalPaymentAmount { get; set; }
    }
}
