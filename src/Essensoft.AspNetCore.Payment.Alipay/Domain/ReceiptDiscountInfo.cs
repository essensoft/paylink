using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ReceiptDiscountInfo Data Structure.
    /// </summary>
    public class ReceiptDiscountInfo : AlipayObject
    {
        /// <summary>
        /// 优惠金额，单位分
        /// </summary>
        [JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 优惠描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }
    }
}
