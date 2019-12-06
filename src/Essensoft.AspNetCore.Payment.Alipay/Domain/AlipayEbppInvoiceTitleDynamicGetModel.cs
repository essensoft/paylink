using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceTitleDynamicGetModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceTitleDynamicGetModel : AlipayObject
    {
        /// <summary>
        /// 抬头动态码
        /// </summary>
        [JsonPropertyName("bar_code")]
        public string BarCode { get; set; }
    }
}
