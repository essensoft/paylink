using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BarcodeInfoVO Data Structure.
    /// </summary>
    public class BarcodeInfoVO : AlipayObject
    {
        /// <summary>
        /// 条形码数字字符串
        /// </summary>
        [JsonPropertyName("barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// 条形码类型, 目前支持"ean8", "ean13", 前者对应的barcode为8位纯数字字符串，后者为13位纯数字字符串
        /// </summary>
        [JsonPropertyName("barcode_type")]
        public string BarcodeType { get; set; }
    }
}
