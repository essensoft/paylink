using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingDataActivityBillDownloadResponse.
    /// </summary>
    public class KoubeiMarketingDataActivityBillDownloadResponse : AlipayResponse
    {
        /// <summary>
        /// 账单下载地址
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
