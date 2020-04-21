using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInvoiceSycnResponse.
    /// </summary>
    public class AlipayEbppInvoiceSycnResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝发票管家发票详情页链接地址  如果同步的发票是多张时，此链接为当前用户的已开立发票列表地址
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
