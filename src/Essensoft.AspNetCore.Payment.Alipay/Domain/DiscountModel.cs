using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DiscountModel Data Structure.
    /// </summary>
    public class DiscountModel : AlipayObject
    {
        /// <summary>
        /// 每期折扣，保留小数点2位
        /// </summary>
        [JsonPropertyName("term_discount")]
        public string TermDiscount { get; set; }

        /// <summary>
        /// 分期期次，0表示不分期，整笔折扣
        /// </summary>
        [JsonPropertyName("term_no")]
        public long TermNo { get; set; }
    }
}
