using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInvoiceInfoSendResponse.
    /// </summary>
    public class AlipayEbppInvoiceInfoSendResponse : AlipayResponse
    {
        /// <summary>
        /// 发票访问地址，同步红票的情况下不返回该字段，同步蓝票的情况下如果同步单张发票，返回发票详情链接地址，如果同步的是多张发票，返回发票列表地址
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
