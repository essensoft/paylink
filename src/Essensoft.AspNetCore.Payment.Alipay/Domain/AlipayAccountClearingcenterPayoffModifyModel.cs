using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAccountClearingcenterPayoffModifyModel Data Structure.
    /// </summary>
    public class AlipayAccountClearingcenterPayoffModifyModel : AlipayObject
    {
        /// <summary>
        /// 是否高优先级处理登记薄
        /// </summary>
        [JsonPropertyName("is_high_priority")]
        public bool IsHighPriority { get; set; }

        /// <summary>
        /// 待解付资金流水号 唯一键
        /// </summary>
        [JsonPropertyName("pay_off_no")]
        public string PayOffNo { get; set; }
    }
}
