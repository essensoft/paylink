using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MultiStagePayLineInfo Data Structure.
    /// </summary>
    public class MultiStagePayLineInfo : AlipayObject
    {
        /// <summary>
        /// 多次支付中的1次支付金额
        /// </summary>
        [JsonPropertyName("payment_amount")]
        public string PaymentAmount { get; set; }

        /// <summary>
        /// 描述分次支付中某一次支付的信息，这个字段标识”次“的数字标识，从0开始；
        /// </summary>
        [JsonPropertyName("payment_idx")]
        public long PaymentIdx { get; set; }
    }
}
