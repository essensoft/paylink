using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataBillDownloadurlGetResponse.
    /// </summary>
    public class AlipayDataBillDownloadurlGetResponse : AlipayResponse
    {
        /// <summary>
        /// 账单下载地址链接，获取连接后30秒后未下载，链接地址失效。
        /// </summary>
        [JsonPropertyName("bill_download_url")]
        public string BillDownloadUrl { get; set; }
    }
}
