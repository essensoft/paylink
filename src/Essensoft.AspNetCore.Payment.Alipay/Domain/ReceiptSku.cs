using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ReceiptSku Data Structure.
    /// </summary>
    public class ReceiptSku : AlipayObject
    {
        /// <summary>
        /// 商品条形码
        /// </summary>
        [JsonPropertyName("barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonPropertyName("count")]
        public long Count { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商品价格，单位分
        /// </summary>
        [JsonPropertyName("price")]
        public long Price { get; set; }
    }
}
