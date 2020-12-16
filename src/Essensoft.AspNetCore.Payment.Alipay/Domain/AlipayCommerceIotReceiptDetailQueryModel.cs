using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotReceiptDetailQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotReceiptDetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 调用发送电子小票接口时返回的电子小票id
        /// </summary>
        [JsonPropertyName("receipt_id")]
        public string ReceiptId { get; set; }
    }
}
