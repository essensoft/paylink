using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GFAOpenAPICommandReceipt Data Structure.
    /// </summary>
    public class GFAOpenAPICommandReceipt : AlipayObject
    {
        /// <summary>
        /// 回执扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 回执状态
        /// </summary>
        [JsonPropertyName("receipt_status")]
        public string ReceiptStatus { get; set; }
    }
}
